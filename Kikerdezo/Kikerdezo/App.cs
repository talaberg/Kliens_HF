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
        private static App theApp;          
        private MainForm AppMainForm;
        
        private static List<Control> DocViews;     // Used views are registered here
        private int ActiveView = 0;
        
        private QuestionBank CurrentQBank; // Currently used quiestion bank object

        public static App Instance
        {
            get { return theApp; }
        }
        public bool AcitvityExists
        {
            get { return CurrentQBank != null; }
        }

        public static void Initialize(MainForm form)
        {
            DocViews = new List<Control>();

            theApp = new App();
            theApp.AppMainForm = form;

        }

        public void NewActivity(string fileName,bool FileExists)
        {
            if (CurrentQBank != null)
            {
                CloseActivity();
            }

            CurrentQBank = new QuestionBank();

            try
            {
                if (FileExists) CurrentQBank.OpenQuestionBank(fileName);    // Open questionbank
                else            CurrentQBank.CreateQuestionBank();

                
                MainMenu M = new MainMenu();
                App.Instance.AppMainForm.GetWorkPanel.Controls.Add(M, 1, 0);
                EditorView E = new EditorView();            // Create and init new editor view
                E.Initialize(ref CurrentQBank);
                E.Name = "Edit";
                E.Anchor = AnchorStyles.None;
                

                DocViews.Add(E);                            // Register in DocViews
                CurrentQBank.AttachView(E);                 // Register in QBank interface
                AppMainForm.GetWorkPanel.Controls.Add(E, 1, 1); // Add to main form controls

                BrowseView B = new BrowseView();            // Create and init new editor view
                B.Initialize(ref CurrentQBank);
                B.Name = "Browse";

                DocViews.Add(B);                            //Register in DocViews
                CurrentQBank.AttachView(B);                 //Register in QBank interface
                AppMainForm.GetWorkPanel.Controls.Add(B, 1, 1); //Add to main form controls

                TestView T = new TestView();            // Create and init new test view
                T.Initialize(ref CurrentQBank);
                T.Name = "Test";
                CurrentQBank.QTestView = T;
                
                DocViews.Add(T);                            //Register in DocViews
                CurrentQBank.AttachView(T);                 //Register in QBank interface
                AppMainForm.GetWorkPanel.Controls.Add(T, 1, 1); //Add to main form controls

                E.Show();
            }
            catch(System.IO.IOException)
            {
                MessageBox.Show("A fájl sérült, vagy használatban van!");
                CurrentQBank = null;
            }
        }
        public void SaveActivity(string FilePath, bool DefaultFilePath)
        {
            if (CurrentQBank != null)
            {
                CurrentQBank.SaveQuestionBank(FilePath, DefaultFilePath);
            }
        }
        public void CloseActivity()
        {
            DocViews.Clear();
            ActiveView = 0;
            CurrentQBank = null;
            AppMainForm.GetWorkPanel.Controls.Clear();
        }

        public void SwitchView(string ViewName)
        {
            int newActiveView = DocViews.FindIndex(x => x.Name == ViewName);

            if (ActiveView != newActiveView)
            {
                DocViews.ElementAt(ActiveView).Hide();
                DocViews.ElementAt(newActiveView).Show();

                ActiveView = newActiveView;
            }

        }


    }
}
