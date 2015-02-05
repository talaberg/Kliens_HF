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
    public class EditorView : UserControl, QView
    {
        private TableLayoutPanel tableLayoutPanel;  //Editor view elements
        private QuestionBank Qbank;
        private NumericUpDown numericKerdesSorszam;
        private GroupBox groupBoxKerdesSorszam;
        private Button buttonMutasd;
        List<TextBox> NewQuestion;
        private Button buttonNext10;
        private Button buttonPrev10;
        private int QuestionStartingNum;
        public EditorView()
        {
            InitializeComponent();
            this.Hide();
            this.Dock = DockStyle.Fill;
            QuestionStartingNum = 0;
        }
        public void Initialize(ref QuestionBank B)
        {
            NewQuestion = new List<TextBox>();
            Qbank = B;            
        }
        public void UpdateView()    // Update editor view
        {
            this.numericKerdesSorszam.Maximum = new decimal(new int[] {Qbank.Questions.Count,0,0,0});
            UpdateTable();
        }


        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.numericKerdesSorszam = new System.Windows.Forms.NumericUpDown();
            this.groupBoxKerdesSorszam = new System.Windows.Forms.GroupBox();
            this.buttonNext10 = new System.Windows.Forms.Button();
            this.buttonPrev10 = new System.Windows.Forms.Button();
            this.buttonMutasd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericKerdesSorszam)).BeginInit();
            this.groupBoxKerdesSorszam.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Location = new System.Drawing.Point(45, 113);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(400, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(400, 3);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // numericKerdesSorszam
            // 
            this.numericKerdesSorszam.Location = new System.Drawing.Point(239, 40);
            this.numericKerdesSorszam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKerdesSorszam.Name = "numericKerdesSorszam";
            this.numericKerdesSorszam.Size = new System.Drawing.Size(70, 20);
            this.numericKerdesSorszam.TabIndex = 1;
            this.numericKerdesSorszam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxKerdesSorszam
            // 
            this.groupBoxKerdesSorszam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxKerdesSorszam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxKerdesSorszam.Controls.Add(this.buttonNext10);
            this.groupBoxKerdesSorszam.Controls.Add(this.buttonPrev10);
            this.groupBoxKerdesSorszam.Controls.Add(this.buttonMutasd);
            this.groupBoxKerdesSorszam.Controls.Add(this.numericKerdesSorszam);
            this.groupBoxKerdesSorszam.Location = new System.Drawing.Point(134, 9);
            this.groupBoxKerdesSorszam.Name = "groupBoxKerdesSorszam";
            this.groupBoxKerdesSorszam.Size = new System.Drawing.Size(419, 86);
            this.groupBoxKerdesSorszam.TabIndex = 2;
            this.groupBoxKerdesSorszam.TabStop = false;
            this.groupBoxKerdesSorszam.Text = "Kérdés sorszáma";
            // 
            // buttonNext10
            // 
            this.buttonNext10.Location = new System.Drawing.Point(118, 38);
            this.buttonNext10.Name = "buttonNext10";
            this.buttonNext10.Size = new System.Drawing.Size(91, 23);
            this.buttonNext10.TabIndex = 4;
            this.buttonNext10.Text = "Következő 10";
            this.buttonNext10.UseVisualStyleBackColor = true;
            this.buttonNext10.Click += new System.EventHandler(this.buttonNext10_Click);
            // 
            // buttonPrev10
            // 
            this.buttonPrev10.Location = new System.Drawing.Point(11, 38);
            this.buttonPrev10.Name = "buttonPrev10";
            this.buttonPrev10.Size = new System.Drawing.Size(91, 23);
            this.buttonPrev10.TabIndex = 3;
            this.buttonPrev10.Text = "Előző 10";
            this.buttonPrev10.UseVisualStyleBackColor = true;
            this.buttonPrev10.Click += new System.EventHandler(this.buttonPrev10_Click);
            // 
            // buttonMutasd
            // 
            this.buttonMutasd.Location = new System.Drawing.Point(325, 38);
            this.buttonMutasd.Name = "buttonMutasd";
            this.buttonMutasd.Size = new System.Drawing.Size(75, 23);
            this.buttonMutasd.TabIndex = 2;
            this.buttonMutasd.Text = "Mutasd";
            this.buttonMutasd.UseVisualStyleBackColor = true;
            this.buttonMutasd.Click += new System.EventHandler(this.buttonMutasd_Click);
            // 
            // EditorView
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.groupBoxKerdesSorszam);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "EditorView";
            this.Size = new System.Drawing.Size(750, 649);
            ((System.ComponentModel.ISupportInitialize)(this.numericKerdesSorszam)).EndInit();
            this.groupBoxKerdesSorszam.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Addlabel(String text, int col, int row)// supplementary function: adds a new label, with the given text to the given position
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tableLayoutPanel.Controls.Add(label, col, row);
        }
        private void UpdateTable() // supplementary function: Updates the tableLayoutPanel
        {
            tableLayoutPanel.Hide();
            tableLayoutPanel.Controls.Clear();
            

            Addlabel("Kérdés", 0, 0);
            Addlabel("Válasz", 1, 0);
            Addlabel("Kulcsszavak", 2, 0);

            int i=0, j=0;
            int NumberOfRows = (Qbank.Questions.Count-QuestionStartingNum < 10) ? (Qbank.Questions.Count-QuestionStartingNum) : 10;

            for (i = QuestionStartingNum; i < QuestionStartingNum + NumberOfRows; i++)
            {
                j = i - QuestionStartingNum;
                for (int k = 0; k < 3; k++)
                {
                    string s;
                    s = Qbank.Questions.ElementAt(i).QAK[k];
                    
                    Addlabel(s, k, j+1);
                }
                DeleteButton b = new DeleteButton();        // Place a delete button at each row, and set the current question's ID
                b.QID = Qbank.Questions.ElementAt(i).QID;
                b.Text = "Törlés";
                b.Anchor = AnchorStyles.None;
                b.Click += new System.EventHandler(this.deleteButton);
                tableLayoutPanel.Controls.Add(b, 3, j+1);              
            }
            j++;
            TextBox t = CreateMultilineTextBox("NewQuestion");
            NewQuestion.Add(t);
            tableLayoutPanel.Controls.Add(t, 0, j + 1);
            
            t = CreateMultilineTextBox("NewAnswer");
            NewQuestion.Add(t);
            tableLayoutPanel.Controls.Add(t, 1, j + 1);

            t = CreateMultilineTextBox("NewKeyword");
            NewQuestion.Add(t);
            tableLayoutPanel.Controls.Add(t, 2, j + 1);            
            
            Button a = new Button();                    // Place an add button
            a.Text = "Hozzáadás";
            a.Anchor = AnchorStyles.None;
            a.Click += new System.EventHandler(this.addButton);
            tableLayoutPanel.Controls.Add(a, 3, j + 1);

            tableLayoutPanel.Show();
        }
        private void deleteButton(object sender, EventArgs e) // A delete button is pressed --> delete that row and its question entry
        {
            DeleteButton b = sender as DeleteButton;

            Qbank.RmvQuestion(b.QID);
            
        }

        private void addButton(object sender, EventArgs e)// add button is pressed --> add new QuestionEntry
        {
            if (NewQuestion.ElementAt(0).Text.Any() && NewQuestion.ElementAt(1).Text.Any() && NewQuestion.ElementAt(2).Text.Any())
            {
                if (NewQuestion.Any())
                {
                    QuestionEntry NewQ = new QuestionEntry();
                    List<string> s = new List<string>();
                    s.Add(NewQuestion.ElementAt(0).Text);
                    s.Add(NewQuestion.ElementAt(1).Text);
                    s.Add(NewQuestion.ElementAt(2).Text);

                    NewQ.QAK = s;

                    Qbank.AddQuestion(NewQ);
                }
            }
            else
            {                                             // Empty cell found
                MessageBox.Show("Minden mező kitöltése kötelező!");
            }
        }
        private TextBox CreateMultilineTextBox(string s) // Supplementary function: Creates a textbox, with multiple line
        {
            TextBox textBox1 = new TextBox();
            
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.WordWrap = true;

            textBox1.Height = 90;
            textBox1.Width = 180;
            textBox1.Anchor = AnchorStyles.None;

            textBox1.Name = s;

            return textBox1;
        }

        private void buttonMutasd_Click(object sender, EventArgs e) // Switch page
        {
            if((QuestionStartingNum - 1) != Convert.ToInt32(numericKerdesSorszam.Value))
            {
                QuestionStartingNum = Convert.ToInt32(numericKerdesSorszam.Value) - 1;
                UpdateTable();
            }
        }

        private void buttonPrev10_Click(object sender, EventArgs e) //Shows the next 10 QuestionEntry
        {
            if (QuestionStartingNum != 0)
            {
                if (QuestionStartingNum - 10 > 0)
                {
                    QuestionStartingNum -= 10;
                }
                else
                {
                    QuestionStartingNum = 0;
                }
                UpdateTable();
                numericKerdesSorszam.Value = QuestionStartingNum + 1;
            }
        }

        private void buttonNext10_Click(object sender, EventArgs e) //Shows the previous 10 QuestionEntry
        {
            if (QuestionStartingNum != Qbank.Questions.Count - 1)
            {
                if (QuestionStartingNum + 10 < Qbank.Questions.Count)
                {
                    QuestionStartingNum += 10;
                }
                else 
                {
                    QuestionStartingNum = Qbank.Questions.Count - 1;
                }
                UpdateTable();
                numericKerdesSorszam.Value = QuestionStartingNum + 1;
            }
        }
    }
}
