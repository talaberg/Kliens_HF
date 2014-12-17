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
    public partial class BrowseView : UserControl, QView
    {
        private int CurrentQ;// Az aktuálisan megjelenítendő kérdés
        private QuestionBank Qbank;// A kérdés bank, amiből dolgozunk
        
        public BrowseView(QuestionBank B)
        {
            InitializeComponent();
            this.Qbank = B;
        }
        public void Update()
        {

            Invalidate();
        }
    }
}
