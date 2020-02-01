using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7_part2
{
    public class CheckboxQuestion : Question
    {
        public bool PartialCreditAllowed { get; set; }

        public CheckboxQuestion(List<string> possibleAnswers,
                                List<string> correctAnswers,
                                bool partialCreditAllowed,
                                string questionText,
                                int skillLevel,
                                string type,
                                int points) :
                                        base(possibleAnswers, correctAnswers, questionText, skillLevel, type, points)
        {
            PartialCreditAllowed = partialCreditAllowed;
        }

        public override int CheckAnswer(List<string> answers)
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

        public override List<string> GetUserAnswer()
        {
            List<string> answers = new List<string>();

            bool exit = false;
            int i = 0;

            while (exit != true)
            {
                string input = Console.ReadLine();
                if (input.ToUpper() == "EXIT")
                {
                    exit = true;
                }
                else
                {
                    answers.Add(input.ToUpper());
                }

            }

            return answers;
        }

    }
}
