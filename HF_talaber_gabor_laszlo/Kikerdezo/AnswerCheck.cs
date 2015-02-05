using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kikerdezo
{
    static class AnswerCheck
    {
        public static bool IsRightAnswer(string Answer, string Keywords)
        {
            string tmp = Keywords.Trim();           // Cut whitespace
            tmp = tmp.ToLower();                    // Only lower case characters

            string ansTmp = Answer.ToLower();       // Only lower case characters

            var keys = tmp.Split(',');              // Create a keyword array

            for (int i = 0; i < keys.Length; i++ )  // Checks if every keyword can be found in the string
            {
                if (ansTmp.IndexOf(keys[i]) == -1) return false;

            }
            return true;

        }
    }
}
