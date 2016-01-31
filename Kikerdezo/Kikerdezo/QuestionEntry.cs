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

        List<string> Images;

        private Int64 ID;
        /// <summary>
        /// Returns with a Question-Answer-Keyword list (QAK)
        /// </summary>
        public QuestionEntry()
        {
            ID = IDGenerator++;
            Images = new List<string>();
        }
        public List<string> QAK
        {
            get
            {
                List<string> x = new List<string>();
                x.Add(Question);
                x.Add(Answer);
                x.Add(Keywords);
                CropImages();
                return x;
            }
            set
            {
                Question = value.ElementAt(0);
                Answer = value.ElementAt(1);
                Keywords = value.ElementAt(2);
            }
        }
        public List<string> AnsImages
        {
            get
            {
                return Images;
            }
        }
        public Int64 QID
        {
            get { return ID; }
        }

        private void CropImages()
        {
            bool StringEnd = false;

            while(!StringEnd) //Find @ chars
            {
                string s = Answer;
                int index = s.IndexOf('@');

                if((index != -1) && (index+1 < s.Length) )
                {
                    s = s.Substring(index+1);

                    int end = s.IndexOf('@');
                    if(end != -1)
                    {
                        Images.Add(s.Substring(0, end));

                        Answer = 
                            Answer.Substring(0, (index!=0 ? index : 0) ) +
                            Answer.Substring(index + end + 2);
                    }
                }
                else
                {
                    StringEnd = true;
                }
            }
            StringEnd = true;
        }
    }
}
