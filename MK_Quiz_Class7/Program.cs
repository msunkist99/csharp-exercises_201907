using System;
using System.Collections.Generic;

namespace MK_Quiz_Class7
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = BuildQuizQuestions();
            PrintQuizQuestions(quiz);

            Console.ReadLine();
        }
        static Quiz BuildQuizQuestions()
        {
            Quiz quiz = new Quiz();
            List<Question> questions = new List<Question>();

            // question1
            List<string> answers = new List<string>();
            answers.Add("A. Rams");
            answers.Add("B. Cardinals");
            answers.Add("C. Browns");
            answers.Add("D. Blues");
            answers.Add("E. Battle Hawks");
            answers.Add("F. Unnamed soccor Team");
            answers.Add("G. Hawks");

            List<string> correctAnswers = new List<string>();
            correctAnswers.Add("B");
            correctAnswers.Add("D");
            correctAnswers.Add("E");
            correctAnswers.Add("F");

            Question question1 = new CheckboxQuestion(answers,
                                                      correctAnswers,
                                                      true,
                                                      "Which are some St. Louis sports teams",
                                                      2,
                                                      "checkbox",
                                                      4);

            questions.Add(question1);
            quiz.Questions = questions;

            // question2
            Question question2 = new TrueFalseQuestion("true/false", 
                                                       "true", 
                                                       "true", 
                                                       "Is St Louis the greatest baseball town?", 
                                                       2, 
                                                       "truefalse", 
                                                       1);

            questions.Add(question2);

            // question3
            answers = new List<string>();
            answers.Add("A. Rams");
            answers.Add("B. Cardinals");
            answers.Add("C. Browns");
            answers.Add("D. Blues");
            answers.Add("E. Battle Hawks");
            answers.Add("F. Unnamed soccor Team");
            answers.Add("G. Hawks");

            Question question3 = new MultipleChoiceQuestion(answers,
                                                            "B",
                                                            "What is the St Louis baseball team?",
                                                            2, 
                                                            "multiplechoice", 
                                                            1);

            questions.Add(question3);

            return quiz;
        }

        static void PrintQuizQuestions(Quiz quiz)
        {
            foreach (Question question in quiz.Questions)
            {
                Console.WriteLine(question.ToString());
            }
        }
    }
}
