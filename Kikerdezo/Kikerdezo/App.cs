using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kikerdezo
{
    public class App
    {
        private Activity CurrentActivity;
        private static App theApp;
        private Form mainForm;
        private QuestionBank Questions;

        public static App Instance()
        {
            return theApp;
        }

        public static void Initialize(Form form)
        {
            theApp = new App();
            theApp.mainForm = form;
        }

        public void CreateQuestionBank()
        {
            throw new System.NotImplementedException();
        }

        public void OpenQuestionBank()
        {
            throw new System.NotImplementedException();
        }
    }
}
