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
        public MainForm()
        {
            InitializeComponent();
            this.Width = 768;
            this.Height = 768;
            
            MainMenu M = new MainMenu();
            WorkPanel.Controls.Add(M, 1, 0);
            WorkPanel.Hide();

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
                App.Instance.NewActivity(openFileDialog1.FileName);           
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



    }
}
