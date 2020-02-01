using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7_part2
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public int ThisQuizScore { get; set; }
        public int QuizPerfectScore
        {
            get
            {
                int perfectScore = 0;
                foreach (Question question in Questions)
                {
                    perfectScore += question.Points;
                }
                return perfectScore;
            }
        }

        public void DisplayAllQuizQuestions()
        {
            foreach (Question question in this.Questions)
            {
                question.DisplayQuestion();
            }
        }
    }
}

