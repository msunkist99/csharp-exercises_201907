using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Quiz_Class7
{
    public class Question : AbstractEntity
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int SkillLevel { get; set; }
        public string Type { get; set; }
        public int Points { get; set; }

        public Question(string questionText, int skillLevel, string type, int points) 
        {
            Id = GenerateId();
            QuestionText = questionText;
            SkillLevel = skillLevel;
            Type = type;
            Points = points;
        }
    }
}
