using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7
{
    public class CheckboxQuestion : Question
    {
        public List<string> AnswersText { get; set; }
        public List<string> CorrectAnswers { get; set; }
        public bool PartialCreditAllowed { get; set; }

        public CheckboxQuestion(List<string> answersText,
                                List<string> correctAnswers,
                                bool partialCreditAllowed,
                                string questionText,
                                int skillLevel,
                                string type,
                                int points) :
                                    base(questionText, skillLevel, type, points)
        {
            AnswersText = answersText;
            CorrectAnswers = correctAnswers;
            PartialCreditAllowed = partialCreditAllowed;
        }

        public override String ToString()
        {
            string answerTextFormatted = null;

            foreach (string answerText in AnswersText)
            {
                answerTextFormatted = answerText + "\n";
            }

            return ($"Skill Level {SkillLevel} \n") +
                   ($"Worth {Points} points \n") +
                   ($"{QuestionText} \n \n") +
                   ($"{answerTextFormatted}") +
                   ($"Select one or more answers");
        }

        public int CheckAnswer(List<string> answers)
        {
            int points = 0;
            foreach (string answer in answers)
            {
                foreach (string correctAnswer in CorrectAnswers)
                {
                    if (answer == correctAnswer)
                    {
                        points++;
                    }
                }
            }

            if (points == Points)
            {
                return Points;
            }
            else
            {
                if (PartialCreditAllowed)
                {
                    return points;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
