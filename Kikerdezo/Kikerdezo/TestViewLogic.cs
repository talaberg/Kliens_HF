using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Kikerdezo
{
    public partial class TestView : UserControl, QView
    {
        private QuestionBank Qbank;// A kérdés bank, amiből dolgozunk

        private List<QuestionEntry> TestPool; // Az éppen futó teszt kérdései
        private List<TextBox> AnswerPool;

        private int TestCorrectAnswers;
        private int TestTime;
        private int CountDown;
        private int TestQNum;

        private bool TestActive;
        private bool TestEnded;
        public TestView()
        {
            TestPool = new List<QuestionEntry>();
            AnswerPool = new List<TextBox>();

            TestCorrectAnswers = 0;
            TestTime = 0;
            CountDown = 0;
            TestQNum = 0;

            InitializeComponent();

            this.Hide();
            this.Dock = DockStyle.Fill;
            labelTestResult.Hide();

            TestActive = false;
            TestEnded = false;
        }
        public void UpdateView()
        {
            
            this.numSetQnum.Maximum = new decimal(new int[] {Qbank.Questions.Count, 0, 0, 0 });
        }
        public void Initialize(ref QuestionBank B)
        {
            Qbank = B;
            groupBoxTimer.Hide();
            tableTest.Hide();
            tableTest.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        // Test preparation ---------------------------------------------------------
        private void PrepareTest()
        {
            TestPool.Clear();
            AnswerPool.Clear();            

            TestQNum = Convert.ToInt32(numSetQnum.Value);

            Random r = new Random();
            List<QuestionEntry> TmpQuestionList = new List<QuestionEntry>(Qbank.Questions); // Temporary list to easly select questions randomly



            for (int i = 0; i < TestQNum; i++ )                 // Generate random question list
            {
                int index = r.Next(TmpQuestionList.Count);
                QuestionEntry TQ = new QuestionEntry();

                TQ = TmpQuestionList.ElementAt(index);
                
                TestPool.Add(TQ);

                TmpQuestionList.Remove(TQ);
            }


            UpdateTestTable(false);

            
        }
        // Result calcultaion -------------------------------------------------------------------------
        private void CalculateResult()
        {
            TestCorrectAnswers = 0;

            UpdateTestTable(true);

            string CorrAnsPercent = ((double)TestCorrectAnswers / (double)TestQNum * 100.0).ToString("F2", CultureInfo.CreateSpecificCulture("hu-HU"));
            string Result = "A teszt véget ért. A helyes válaszok száma : {0}/{1} - ({2} %)";
            Result = string.Format(Result, TestCorrectAnswers.ToString(),TestQNum, CorrAnsPercent);

            labelTestResult.Text = Result;
            labelTestResult.Show();

            
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            if (--CountDown <= 0)
            {
                
                labelTimer.Text = "00:00";
                EndTest();
            }
            else
            {
                TimeSpan result = TimeSpan.FromSeconds(CountDown);
                string TimeString = result.ToString("mm':'ss");
                labelTimer.Text = TimeString;
            }
        }
        // Events -------------------------------------------------------------------

        private void bTestStart_Click(object sender, EventArgs e)
        {
            if (Qbank.Questions.Any())
            {
                if (!TestActive)
                {
                    PrepareTest();

                    CountDown = Convert.ToInt32(numSetTestTime.Value);
                    TestTime = Convert.ToInt32(numSetTestTime.Value);

                    timerTest.Interval = 1000;
                    timerTest.Enabled = true;
                    timerTest.Start();

                    TimeSpan result = TimeSpan.FromSeconds(CountDown);
                    string TimeString = result.ToString("mm':'ss");
                    labelTimer.Text = TimeString;

                    groupBoxTimer.Show();
                    labelTestResult.Hide();

                    TestActive = true;
                    TestEnded = false;
                }
            }
            else
            {
                MessageBox.Show("Jelenleg a kérdésbank üres. Adj hozzá kérdéseket, vagy tölts be egy másikat!");
            }

        }
        private void bEnd_Click(object sender, EventArgs e)
        {
            if (!TestEnded && TestActive)
            {
                EndTest();
            }
        }

        private void EndTest()
        {
            timerTest.Stop();
            timerTest.Enabled = false;
            CalculateResult();
            
            TestActive = false;
            TestEnded = true;
        }

        // Supplementary functions --------------------------------------------------
        private void AddTestlabel(String text, int col, int row)
        {
            GrowLabel label = new GrowLabel();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(5, 0);            
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label.Anchor = AnchorStyles.Left;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label.MaximumSize = new System.Drawing.Size(200, 0);
            
            tableTest.Controls.Add(label, col, row);
        }
        private TextBox CreateMultilineTextBox(string s)
        {
            TextBox textBox1 = new TextBox();

            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.WordWrap = true;

            textBox1.Location = new System.Drawing.Point(15, 0);

            textBox1.Height = 90;
            textBox1.Width = 180;
            textBox1.Anchor = AnchorStyles.None;
            
            textBox1.Name = s;

            textBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            return textBox1;
        }

        private GroupBox CreateRightAnswerBox(string UserAnswer, string RightAnswer, string keywords)
        {
           GroupBox G = new System.Windows.Forms.GroupBox();
           Label Megold = new Label();
           // Right answer label formatting ----------------------------------
           Megold.AutoSize = true;
           Megold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
           Megold.Location = new System.Drawing.Point(6, 28);
           Megold.MaximumSize = new System.Drawing.Size(175, 0);
           Megold.Name = "Megold";
           Megold.Size = new System.Drawing.Size(54, 17);
           Megold.TabIndex = 1;           
           Megold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
           // Groupbox  formatting ------------------------------------------
           G.AutoSize = true;
           G.Controls.Add(Megold);
           G.Location = new System.Drawing.Point(15, 0);
           G.Name = "megoldBox";
           G.Size = new System.Drawing.Size(180, 90);
           G.TabIndex = 7;
           G.TabStop = false;
           G.Text = "megoldBox";
           G.MaximumSize = new System.Drawing.Size(180,0);
           G.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);


           Megold.Text = RightAnswer; //Show correct answer

           if (AnswerCheck.IsRightAnswer(UserAnswer, keywords)) // Answer check
           {
               G.Text = "Helyes válasz!";
               G.BackColor = Color.Green;

               TestCorrectAnswers++;
           }
           else
           {
               G.Text = "Helytelen válasz!";
               G.BackColor = Color.Red;
           }           

           return G;

        }

        private void UpdateTestTable(bool TestEnd)
        {
            tableTest.Hide();
            tableTest.Controls.Clear();

            for (int i = 0; i < TestQNum; i++)
            {

                string s;
                s = TestPool.ElementAt(i).QAK[0];            // First coloumn : Question
                AddTestlabel(s, 0, i);

                TextBox T = new TextBox();
                if (!TestEnd)
                {
                    T = CreateMultilineTextBox(TestPool.ElementAt(i).QID.ToString());   // Second coloumn : User answer in textbox

                    AnswerPool.Add(T);
                }
                else
                {
                                                                // If Update is called after a test, Answerpool already created
                }
                {
                    T = AnswerPool.ElementAt(i);
                }

                tableTest.Controls.Add(T, 1, i);

                string UsrAns = AnswerPool.ElementAt(i).Text;
                string RgtAns = TestPool.ElementAt(i).QAK[1];
                string KeyWrd = TestPool.ElementAt(i).QAK[2];

                GroupBox GrB = CreateRightAnswerBox(UsrAns, RgtAns, KeyWrd);   // Third coloumn : answercheck (only shown after the test)
                if (TestEnd) GrB.Show();
                else GrB.Hide();

                tableTest.Controls.Add(GrB, 2, i);
            }

            tableTest.Show();
        }

    }
}
