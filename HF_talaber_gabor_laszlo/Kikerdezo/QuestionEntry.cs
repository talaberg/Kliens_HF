using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kikerdezo
{
    public class QuestionEntry
    {
        private static Int64 IDGenerator = 0;
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

        private Int64 ID;
        /// <summary>
        /// Returns with a Question-Answer-Keyword list (QAK)
        /// </summary>
        public QuestionEntry()
        {
            ID = IDGenerator++;// The ID of the question entry will be unique
        }
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
        public Int64 QID
        {
            get { return ID; }
        }
    }
}
