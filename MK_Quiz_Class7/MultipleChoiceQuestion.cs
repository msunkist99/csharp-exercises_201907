using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7
{
    public class MultipleChoiceQuestion : Question
    {
        public List<string> AnswersText { get; set; }
        public string CorrectAnswer { get; set; }

        public MultipleChoiceQuestion(List<string> answersText,
                                      string correctAnswer,
                                      string questionText,
                                      int skillLevel,
                                      string type,
                                      int points) :
                                            base(questionText, skillLevel, type, points)
        {
            AnswersText = answersText;
            CorrectAnswer = correctAnswer;
        }

        public override String ToString()
        {
            string answerTextFormatted = null; 

            foreach (string answerText in AnswersText)
            {
                answerTextFormatted += answerText + "\n";
            }

            return ($"\nSkill Level {SkillLevel} \n") +
                   ($"Worth {Points} points \n") +
                   ($"{QuestionText} \n") +
                   ($"{answerTextFormatted}") + 
                   ($"Select one answer");
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
