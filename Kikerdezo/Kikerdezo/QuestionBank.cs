using System;
using System.Collections.Generic;
using System.Globalization;
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
        private TestView QuestionTestView;
        private string QFilePath;
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
        public TestView QTestView
        {
            get { return QuestionTestView; }
            set { QuestionTestView = value;
            QuestionTestView.DiagramPanel.Paint += new PaintEventHandler(control_Paint);
            }
        }
        public void CreateQuestionBank()
        { }

        public void OpenQuestionBank(string filePath)
        {
           /* try
            {*/
            if (filePath.EndsWith(".csv", true, CultureInfo.CreateSpecificCulture("hu-HU")))
            {
                var reader = new StreamReader(File.OpenRead(filePath), Encoding.GetEncoding("iso-8859-2")); // Fájl megnyitása
                QFilePath = filePath;

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
            }
            else
            {
                MessageBox.Show("Hibás fájlformátum! Próbálkozz egy .csv fájlal!");
            }
           /* }
            catch
            {
                MessageBox.Show("Hiba a fájl megnyitása közben!");
            }*/
            
        }
        public void SaveQuestionBank(string fileName, bool DefaultFilePath)
        {
            string SaveDest;
            if (DefaultFilePath) SaveDest = QFilePath;
            else SaveDest = fileName;

            if (!File.Exists(SaveDest))
            {
               // File.Create(SaveDest).Close();
            }
            else
            {                
                File.Delete(SaveDest);
            }
            string delimiter = ";";

            string[][] output = new string[QuestionEntries.Count()][];
            for (int i = 0; i < output.Length; i++) 
            {
                output[i] = new string[3];
            }
            ;
            for (int i = 0; i < QuestionEntries.Count(); i++)
            {
                string ImgPath = "";
                output[i][0] = Questions.ElementAt(i).QAK[0];
                
                for (int j = 0; j < Questions.ElementAt(i).AnsImages.Count; j++)
                {
                    ImgPath += ("@" + Questions.ElementAt(i).AnsImages.ElementAt(j) + "@");
                }
                output[i][1] = Questions.ElementAt(i).QAK[1] + ImgPath;
                output[i][2] = Questions.ElementAt(i).QAK[2];
            }

            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                sb.AppendLine(string.Join(delimiter, output[i]));
            }

            File.AppendAllText(SaveDest, sb.ToString(), Encoding.GetEncoding("iso-8859-2"));

        }

        public void AddQuestion(QuestionEntry Q)
        {
            QuestionEntries.Add(Q);
            UpdateAllViews();
        }

        public void RmvQuestion(Int64 ID)
        {
            int Qindex = QuestionEntries.FindIndex(x => x.QID == ID);
            QuestionEntries.RemoveAt(Qindex);
            UpdateAllViews();
        }
        public static void SaveQuestionBank()
        {
            throw new System.NotImplementedException();
        }

        public void AttachView(QView v)
        {
            Views.Add(v);
            v.UpdateView();
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
                view.UpdateView();
        }

        private void control_Paint(object sender, PaintEventArgs e)
        {
            QuestionTestView.draw(e.Graphics);
        }

    }
}
