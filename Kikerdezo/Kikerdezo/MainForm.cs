using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
