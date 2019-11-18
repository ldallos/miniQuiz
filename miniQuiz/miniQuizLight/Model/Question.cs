using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniQuizLight.Model
{
    public class Question
    {
        public Question()
        {
            Answers = new List<string>();
        }

        public string QuestionText { get; set; }

        public string GoodAnswer { get; set; }

        public List<string> Answers { get; }
    }
}
