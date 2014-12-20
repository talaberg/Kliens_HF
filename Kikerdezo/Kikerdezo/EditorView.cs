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
        public EditorView()
        {
            InitializeComponent();
            this.Hide();
            
        }
        public void Initialize(ref QuestionBank B)
        {
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
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableLayoutPanel.Location = new System.Drawing.Point(168, 50);
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
            // EditorView
            // 
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "EditorView";
            this.Size = new System.Drawing.Size(787, 368);
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
            
            for (int i = 0; i < Qbank.Questions.Count; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    string s;
                    s = Qbank.Questions.ElementAt(i).QAK[k];
                    
                    Addlabel(s, k, i+1);
                }
                DeleteButton b = new DeleteButton();        // Place a delete button at each row, and set the current question's ID
                b.QID = Qbank.Questions.ElementAt(i).QID;
                b.Text = "delete";
                b.Click += new System.EventHandler(this.deleteButton);
                tableLayoutPanel.Controls.Add(b, 4, i+1);

                tableLayoutPanel.Show();
            }
        }
        private void deleteButton(object sender, EventArgs e)
        {
            DeleteButton b = sender as DeleteButton;

            Qbank.RmvQuestion(b.QID);
            
        }
    }
}
