using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7
{
    public class TrueFalseQuestion : Question
    {
        public List<string> AnswersText { get; set; }
        public bool CorrectAnswer { get; set; }
        public string CorrectAnswerText { get; set; }

        public TrueFalseQuestion(List<string> answersText, 
                                 bool correctAnswer, 
                                 string correctAnswerText, 
                                 string questionText, 
                                 int skillLevel, 
                                 string type, 
                                 int points) : 
                                    base(questionText, skillLevel, type, points)
        {
            AnswersText = answersText;
            CorrectAnswer = correctAnswer;
            CorrectAnswerText = correctAnswerText;
        }

        public override String ToString()
        {
            return ($"Skill Level {SkillLevel} \n") +
                   ($"Worth {Points} points \n") +
                   ($"{QuestionText} \n \n") +
                   ($"Select true or false");
        }

        public int CheckAnswer(bool answer)
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
