using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        public void UpdateView()
        {
            
            this.numSetQnum.Maximum = new decimal(new int[] {Qbank.Questions.Count, 0, 0, 0 });
        }
        public void Initialize(ref QuestionBank B)
        {
            Qbank = B;
            groupBoxTimer.Hide();
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
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            if (--CountDown <= 0)
            {
                timerTest.Stop();
                labelTimer.Text = "00:00";
                CalculateResult();
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
            PrepareTest();

            CountDown = Convert.ToInt32(numSetTestTime.Value);
            TestTime = Convert.ToInt32(numSetTestTime.Value);

            timerTest.Interval = 1000;
            timerTest.Enabled = true;
            timerTest.Start();

            groupBoxTimer.Show();

        }
        private void bEnd_Click(object sender, EventArgs e)
        {
            timerTest.Stop();
            CalculateResult();
        }

        // Supplementary functions --------------------------------------------------
        private void AddTestlabel(String text, int col, int row)
        {
            GrowLabel label = new GrowLabel();
            label.Dock = DockStyle.Fill;
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tableTest.Controls.Add(label, col, row);
        }
        private TextBox CreateMultilineTextBox(string s)
        {
            TextBox textBox1 = new TextBox();

            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.WordWrap = true;

            textBox1.Height = 100;
            textBox1.Anchor = AnchorStyles.None;

            textBox1.Name = s;

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
           Megold.MaximumSize = new System.Drawing.Size(425, 0);
           Megold.Name = "Megold";
           Megold.Size = new System.Drawing.Size(54, 17);
           Megold.TabIndex = 1;           
           Megold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
           // Groupbox  formatting ------------------------------------------
           G.AutoSize = true;
           G.Controls.Add(Megold);
           G.Location = new System.Drawing.Point(38, 399);
           G.Name = "megoldBox";
           G.Size = new System.Drawing.Size(425, 96);
           G.TabIndex = 7;
           G.TabStop = false;
           G.Text = "megoldBox";


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

        private void UpdateTestTable(bool ResultShown)
        {
            tableTest.Controls.Clear();

            for (int i = 0; i < TestQNum; i++)
            {

                string s;
                s = Qbank.Questions.ElementAt(i).QAK[0];            // First coloumn : Question
                AddTestlabel(s, 0, i);

                TextBox T = CreateMultilineTextBox(i.ToString());   // Second coloumn : User answer in textbox

                AnswerPool.Add(T);
                tableTest.Controls.Add(T, 1, i);

                string UsrAns = AnswerPool.ElementAt(i).Text;
                string RgtAns = TestPool.ElementAt(i).QAK[1];
                string KeyWrd = TestPool.ElementAt(i).QAK[2];

                GroupBox GrB = CreateRightAnswerBox(UsrAns, RgtAns, KeyWrd);   // Third coloumn : answercheck (only shown after the test)
                if (ResultShown) GrB.Show();
                else GrB.Hide();

                tableTest.Controls.Add(GrB, 2, i);
            }
        }

    }
}
