using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7
{
    public class TrueFalseQuestion : Question
    {
        public string Answer { get; set; }
        public string CorrectAnswer { get; set; }
        public string CorrectAnswerText { get; set; }

        public TrueFalseQuestion(string answer, 
                                 string correctAnswer, 
                                 string correctAnswerText, 
                                 string questionText, 
                                 int skillLevel, 
                                 string type, 
                                 int points) : 
                                    base(questionText, skillLevel, type, points)
        {
            Answer = answer;
            CorrectAnswer = correctAnswer;
            CorrectAnswerText = correctAnswerText;
        }

        public override String ToString()
        {
            return ($"\nSkill Level {SkillLevel} \n") +
                   ($"Worth {Points} points \n") +
                   ($"{QuestionText} \n") +
                   ($"Select true or false");
        }

        public int CheckAnswer(string answer)
        {
            if (answer == CorrectAnswer)
            {
                return Points;
            }
            else
            {
                return 0;
            }
        }
    }
}
