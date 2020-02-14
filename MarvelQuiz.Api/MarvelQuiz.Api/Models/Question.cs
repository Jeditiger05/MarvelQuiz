using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelQuiz.Api.Models
{
    public class Question
    {
        public string Quest { get; set; }
        public string Ans1 { get; set; }
        public string Ans2 { get; set; }
        public string Ans3 { get; set; }
        public string Ans4 { get; set; }
        public string Correct { get; set; }

        public Question(string quest, string ans1, string ans2, string ans3, string ans4, string correct)
        {
            Quest = quest;
            Ans1 = ans1;
            Ans2 = ans2;
            Ans3 = ans3;
            Ans4 = ans4;
            Correct = correct;
        }
    }
}
