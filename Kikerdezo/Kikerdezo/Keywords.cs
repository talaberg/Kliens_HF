using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kikerdezo
{
    public class Keywords
    {
        /// <summary>
        /// Stores a keyword list
        /// </summary>
        private List<string> k;

        public List<string> K
        {
            get
            {
                return k;
            }
            set
            {
                k = value;
            }
        }
    }
}
