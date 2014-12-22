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
            Update();
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
            megoldBox.Hide();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (checkBoxRand.Checked)
            {                
                Random r = new Random();
                int NextQ = r.Next(Qbank.Questions.Count);
                if (NextQ == CurrentQ)
                {
                    if (CurrentQ < Qbank.Questions.Count - 1) CurrentQ++;
                    else if (CurrentQ > 0) CurrentQ--;
                }
                else CurrentQ = NextQ;
            }
            else 
            {
                if (CurrentQ < Qbank.Questions.Count - 1)
                {
                    CurrentQ++;
                    
                }
            }

            UpdateView();
            
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (CurrentQ > 0)
            {
                CurrentQ--;
                UpdateView();
            }
        }

        private void elkuld_Click(object sender, EventArgs e)
        {
            if (Qbank.Questions.Any())
            {
                if (AnswerCheck.IsRightAnswer(Valasz.Text, Qbank.Questions.ElementAt(CurrentQ).QAK[2]))
                {
                    megoldBox.Text = "Helyes válasz!";
                    megoldBox.BackColor = Color.Green;
                    megoldBox.Show();
                }
                else
                {
                    megoldBox.Text = "Helytelen válasz!";
                    megoldBox.BackColor = Color.Red;
                    megoldBox.Show();
                }
            }
        }

        private void checkBoxRand_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRand.Checked)
            {
                Random r = new Random();
                CurrentQ = r.Next(Qbank.Questions.Count);

                buttonPrevious.Hide();
            }
            else
            {
                buttonPrevious.Show();
            }
        }

    }
}
