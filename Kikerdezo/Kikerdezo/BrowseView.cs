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
    public partial class BrowseView : UserControl, QView
    {
        private int CurrentQ;// Az aktuálisan megjelenítendő kérdés
        private QuestionBank Qbank;// A kérdés bank, amiből dolgozunk
        
        public BrowseView()
        {
            InitializeComponent();
            this.Hide();
            this.Dock = DockStyle.Fill;

        }
        public void Initialize(ref QuestionBank B)
        {
            this.Qbank = B;
            CurrentQ = 0;
            Kerdes.Text = Qbank.Questions.ElementAt(CurrentQ).QAK[0];
            Megold.Text = Qbank.Questions.ElementAt(CurrentQ).QAK[1];
        }
        public void UpdateView()
        {
            if (Qbank.Questions.Any())
            {
                Kerdes.Text = Qbank.Questions.ElementAt(CurrentQ).QAK[0];
                Megold.Text = Qbank.Questions.ElementAt(CurrentQ).QAK[1];
            }
            else
            {
                Kerdes.Text = "A kérdésbank jelenleg üres...";
                Megold.Text = "";
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (CurrentQ < Qbank.Questions.Count - 1)
            {
                CurrentQ += 1;
                UpdateView();
            }
            
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (CurrentQ > 0)
            {
                CurrentQ -= 1;
                UpdateView();
            }
        }
    }
}
