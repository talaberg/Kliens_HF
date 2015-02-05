using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kikerdezo
{
    class DeleteButton : Button
    {
        private Int64 ID;

        public Int64 QID
        {
            get { return ID; }
            set { ID = value;  }
        }
    }
}
