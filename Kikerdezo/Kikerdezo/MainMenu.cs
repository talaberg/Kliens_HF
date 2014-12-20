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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            App.Instance.SwitchView("Browse");
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            App.Instance.SwitchView("Edit");
        }
    }
}
