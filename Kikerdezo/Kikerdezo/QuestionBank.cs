using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kikerdezo
{
    public class QuestionBank
    {
        /// <summary>
        /// Qustion entries of the question bank.
        /// </summary>
        private List<QuestionEntry> QuestionEntries;
        private List<QView> Views;

        /// <summary>
        /// Returns with the whole Question bank.
        /// </summary>
        public QuestionBank()
        {
            QuestionEntries = new List<QuestionEntry>();
            Views = new List<QView>();
        }
        public List<QuestionEntry> Questions
        {
            get
            {
                return QuestionEntries;
            }
            set
            {
            }
        }
        public static void CreateQuestionBank()
        {
            throw new System.NotImplementedException();
        }

        public void OpenQuestionBank(string fileName)
        {
           /* try
            {*/
            var reader = new StreamReader(File.OpenRead(fileName), Encoding.GetEncoding("iso-8859-2")); // Fájl megnyitása

                try
                {

                    QuestionEntries = new List<QuestionEntry>();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();// Egy sor kiolvasása
                        var values = line.Split(';');

                        if (values.Length > 2)// Csak akkor tesszük be, ha valid sor: legalább 3 eleme van
                        {
                            List<string> s = new List<string>();
                            s.Add(values[0]);
                            s.Add(values[1]);
                            s.Add(values[2]);

                            QuestionEntry Q = new QuestionEntry();// Kérdés bejegyzés összeállítása
                            Q.QAK = s;

                            QuestionEntries.Add(Q);
                        }
                    }


                }
                catch
                {
                    MessageBox.Show("Hiba a fájl beolvasása közben!");
                }
                finally
                {
                    reader.Dispose();
                }
           /* }
            catch
            {
                MessageBox.Show("Hiba a fájl megnyitása közben!");
            }*/
            
        }

        public static void SaveQuestionBank()
        {
            throw new System.NotImplementedException();
        }

        public void AttachView(QView v)
        {
            Views.Add(v);
            v.Update();
        }
        public void DetachView(QView v)
        {
            Views.Remove(v);
        }
        public void SwitchView(int index)
        {
            //Views.ElementAt(ActiveViewIndex).
        }
        protected void UpdateAllViews()
        {
            foreach (QView view in Views)
                view.Update();
        }

    }
}
