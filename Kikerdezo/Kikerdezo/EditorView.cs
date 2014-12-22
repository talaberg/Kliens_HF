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
        private TableLayoutPanel tableLayoutPanel;
        private QuestionBank Qbank;// A kérdés bank, amiből dolgozunk
        List<TextBox> NewQuestion;
        public EditorView()
        {
            InitializeComponent();
            this.Hide();
            this.Dock = DockStyle.Fill;
        }
        public void Initialize(ref QuestionBank B)
        {
            NewQuestion = new List<TextBox>();
            Qbank = B;            
        }
        public void UpdateView()
        {
            UpdateTable();
        }


        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(400, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(787, 3);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // EditorView
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "EditorView";
            this.Size = new System.Drawing.Size(787, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Addlabel(String text, int col, int row)
        {
            GrowLabel label = new GrowLabel();
            label.Dock = DockStyle.Fill;
            label.Text = text;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            tableLayoutPanel.Controls.Add(label, col, row);
        }
        private void UpdateTable()
        {
            tableLayoutPanel.Hide();
            tableLayoutPanel.Controls.Clear();

            Addlabel("Kérdés", 0, 0);
            Addlabel("Válasz", 1, 0);
            Addlabel("Kulcsszavak", 2, 0);

            int i;
            for (i = 0; i < Qbank.Questions.Count; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    string s;
                    s = Qbank.Questions.ElementAt(i).QAK[k];
                    
                    Addlabel(s, k, i+1);
                }
                DeleteButton b = new DeleteButton();        // Place a delete button at each row, and set the current question's ID
                b.QID = Qbank.Questions.ElementAt(i).QID;
                b.Text = "Törlés";
                b.Anchor = AnchorStyles.None;
                b.Click += new System.EventHandler(this.deleteButton);
                tableLayoutPanel.Controls.Add(b, 3, i+1);                
            }
            TextBox t = CreateMultilineTextBox("NewQuestion");
            NewQuestion.Add(t);
            tableLayoutPanel.Controls.Add(t, 0, i + 1);

            t = CreateMultilineTextBox("NewAnswer");
            NewQuestion.Add(t);
            tableLayoutPanel.Controls.Add(t, 1, i + 1);

            t = CreateMultilineTextBox("NewKeyword");
            NewQuestion.Add(t);
            tableLayoutPanel.Controls.Add(t, 2, i + 1);            

            Button a = new Button();                    // Place an add button
            a.Text = "Hozzáadás";
            a.Anchor = AnchorStyles.None;
            a.Click += new System.EventHandler(this.addButton);
            tableLayoutPanel.Controls.Add(a, 3, i + 1); 

            tableLayoutPanel.Show();
        }
        private void deleteButton(object sender, EventArgs e)
        {
            DeleteButton b = sender as DeleteButton;

            Qbank.RmvQuestion(b.QID);
            
        }

        private void addButton(object sender, EventArgs e)
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
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
            }
        }
        private TextBox CreateMultilineTextBox(string s)
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
    }
}
