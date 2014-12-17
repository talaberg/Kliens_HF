using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kikerdezo
{
    public class QuestionEntry
    {
        /// <summary>
        /// Stores a question.
        /// </summary>
        private string Question;
        /// <summary>
        /// Stores an answer.
        /// </summary>
        private string Answer;
        /// <summary>
        /// Stores a list of keywords.
        /// </summary>
        private string Keywords;

        /// <summary>
        /// Returns with a Question-Answer-Keyword list (QAK)
        /// </summary>
        public List<string> QAK
        {
            get
            {
                List<string> x = new List<string>();
                x.Add(Question);
                x.Add(Answer);
                x.Add(Keywords);
                return x;
            }
            set
            {
                Question = value.ElementAt(0);
                Answer = value.ElementAt(1);
                Keywords = value.ElementAt(2);
            }
        }
    }
}
