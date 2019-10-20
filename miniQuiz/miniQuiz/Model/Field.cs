using System.Collections.Generic;

namespace miniQuiz.Model
{
    public class Field
    {
        public Field()
        {
            Message = string.Empty;
            Reward = 0;
            Questions = new List<string>();
            X = 0;
            Y = 0;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public string Message { get; set; }

        public int Reward { get; set; }

        public List<string> Questions { get; }
    }
}
