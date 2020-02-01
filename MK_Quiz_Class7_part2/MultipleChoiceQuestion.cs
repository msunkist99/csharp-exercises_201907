using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7_part2
{
    public class MultipleChoiceQuestion : Question
    {
        public MultipleChoiceQuestion(List<string> possibleAnswers,
                                      List<string> correctAnswers,
                                      string questionText,
                                      int skillLevel,
                                      string type,
                                      int points) :
                                        base(possibleAnswers, correctAnswers, questionText, skillLevel, type, points)
        {
        }
    }
}
