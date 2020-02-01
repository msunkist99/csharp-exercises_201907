using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7_part2
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(List<string> possibleAnswers,
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
