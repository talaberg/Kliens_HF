using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kikerdezo
{
    public class App
    {
        private Activity CurrentActivity;
        private static App theApp;
        private Form AppMainForm;
        private QuestionBank CurrentQBank = null;

        public static App Instance
        {
            get { return theApp; }
        }

        public static void Initialize(Form form)
        {
            theApp = new App();
            theApp.AppMainForm = form;
        }
        public void NewActivity(string fileName)
        {
            if (CurrentQBank != null)
            {
                MessageBox.Show("Egy kérdésbank már meg van nyitva!");
                return;
            }

            CurrentQBank = new QuestionBank();
            try
            {
                CurrentQBank.OpenQuestionBank(fileName);
                BrowseView B = new BrowseView(CurrentQBank);
                B.Name = "Browse";
                CurrentQBank.AttachView(B);
                AppMainForm.Controls.Add(B);
                
            }
            catch(System.IO.IOException)
            {
                MessageBox.Show("A fájl sérült, vagy használatban van!");
                CurrentQBank = null;
            }
        }


    }
}
