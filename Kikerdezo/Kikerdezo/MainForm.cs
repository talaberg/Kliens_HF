﻿using System;
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

            // Létrehozzunk az alkalmazás objektumot.
            App.Initialize(this);
       
        }

        private void megnyitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {              
                App.Instance.NewActivity(openFileDialog1.FileName);           

            }
        }


    }
}
