using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7_part2
{
    public class Question : AbstractEntity
    {
        public int Id { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public List<string> CorrectAnswers { get; set; }
        public string QuestionText { get; set; }
        public int SkillLevel { get; set; }
        public string Type { get; set; }
        public int Points { get; set; }


        public Question(List<string> possibleAnswers, 
                        List<string> correctAnswers, 
                        string questionText, 
                        int skillLevel, 
                        string type, 
                        int points)
        {
            Id = GenerateId();
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
            QuestionText = questionText;
            SkillLevel = skillLevel;
            Type = type;
            Points = points;
        }

        public virtual List<string> GetUserAnswer()
        {
            List<string> answers = new List<string>();

            answers.Add(Console.ReadLine().ToUpper().Trim());

            return answers;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(this.ToString());
        }

        public virtual int CheckAnswer(List<string> answers)
        {
            if (answers[0] == this.CorrectAnswers[0])
            {
                return Points;
            }
            else
            {
                return 0;
            }
        }

        public override String ToString()
        {
            string toString = 
                   ($"\nSkill Level {this.SkillLevel} \n") +
                   ($"Worth {this.Points} points \n") +
                   ($"{this.QuestionText} \n");

            string answerTextFormatted = null;

            foreach (string answerText in PossibleAnswers)
            {
                answerTextFormatted += answerText + "\n";
            }

            toString += answerTextFormatted;

            if (this.Type == "checkbox")
            {
                toString += ($"Select one or more answers");
            }
            else if (this.Type == "multiplechoice")
            {
                toString += ($"Select one answer");
            }
            else  // Type == "truefalse"
            {
                toString += ($"Select true or false");
            }

            return toString;
        }
    }
}