using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kikerdezo
{
    public partial class MainForm : Form
    {
        private bool NewFile = false; 
        public MainForm()
        {
            
            InitializeComponent();
            this.Width = 768;
            this.Height = 768;

            //Icon myIcon = new Icon("Resources/icon.ico");
            //this.Icon = myIcon;


            WorkPanel.Hide();

            openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            saveFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            // Létrehozzunk az alkalmazás objektumot.
            App.Initialize(this);
       
        }
        public TableLayoutPanel GetWorkPanel
        {
            get { return WorkPanel; }
        }
        private void megnyitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                WorkPanel.Show();
                App.Instance.NewActivity(openFileDialog1.FileName,true);
                NewFile = false;
            }
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bezarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkPanel.Hide();
            App.Instance.CloseActivity();
        }

        private void ujKerdesbankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkPanel.Show();
            App.Instance.NewActivity(null, false);
            NewFile = true;
        }

        private void mentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NewFile)
            {
                mentesMaskentToolStripMenuItem_Click(sender, e);
            }
            else
            {
                if (App.Instance.AcitvityExists)
                {
                    App.Instance.SaveActivity(null, true);
                }
            }
        }

        private void mentesMaskentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (App.Instance.AcitvityExists)
            {
                saveFileDialog1.Filter = "CSV fájl | *.csv";
                saveFileDialog1.DefaultExt = "csv";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.CheckFileExists = false;
                saveFileDialog1.CreatePrompt = true;
                saveFileDialog1.ShowDialog();
            }
        }

        private void saveFileDialog1SavePressed(object sender, CancelEventArgs e)
        {
            App.Instance.SaveActivity(saveFileDialog1.FileName, false);
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/10fLxB5Gjwg0d5TOSiqK3wsJtl8EDhmjWqbuWZVGgXEI");
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verzió: 1.0\n\nBoldog karácsonyt Barbi! :)");
        }



    }
}
