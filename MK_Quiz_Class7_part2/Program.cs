using System;
using System.Collections.Generic;

namespace MK_Quiz_Class7_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = BuildQuizQuestions();
            //quiz.DisplayAllQuizQuestions();

            foreach (Question question in quiz.Questions)
            {
                question.DisplayQuestion();
                List<string> userAnswers = question.GetUserAnswer();
                quiz.ThisQuizScore += question.CheckAnswer(userAnswers);
            }

            Console.WriteLine($"Perfect quiz score - {quiz.QuizPerfectScore}");
            Console.WriteLine($"This quiz score - {quiz.ThisQuizScore}");

            Console.ReadLine();
        }
        
        
        
        static Quiz BuildQuizQuestions()
        {
            Quiz quiz = new Quiz();
            List<Question> questions = new List<Question>();

            // question1
            List<string> possibleAnswers = new List<string>();
            possibleAnswers.Add("A. Rams");
            possibleAnswers.Add("B. Cardinals");
            possibleAnswers.Add("C. Browns");
            possibleAnswers.Add("D. Blues");
            possibleAnswers.Add("E. Battle Hawks");
            possibleAnswers.Add("F. Unnamed soccor Team");
            possibleAnswers.Add("G. Hawks");

            List<string> correctAnswers = new List<string>();
            correctAnswers.Add("B");
            correctAnswers.Add("D");
            correctAnswers.Add("E");
            correctAnswers.Add("F");

            Question question1 = new CheckboxQuestion(possibleAnswers,
                                                      correctAnswers,
                                                      true,
                                                      "Which are some St. Louis sports teams",
                                                      2,
                                                      "checkbox",
                                                      4);

            questions.Add(question1);
            quiz.Questions = questions;

            // question2
            possibleAnswers = new List<string>();
            possibleAnswers.Add("True/False");

            correctAnswers = new List<string>();
            correctAnswers.Add("TRUE");

            Question question2 = new TrueFalseQuestion(possibleAnswers,
                                                       correctAnswers,
                                                       "Is St Louis the greatest baseball town?",
                                                       2,
                                                       "truefalse",
                                                       1);

            questions.Add(question2);

            // question3
            correctAnswers = new List<string>();
            correctAnswers.Add("B");

            possibleAnswers = new List<string>();
            possibleAnswers.Add("A. Rams");
            possibleAnswers.Add("B. Cardinals");
            possibleAnswers.Add("C. Browns");
            possibleAnswers.Add("D. Blues");
            possibleAnswers.Add("E. Battle Hawks");
            possibleAnswers.Add("F. Unnamed soccor Team");
            possibleAnswers.Add("G. Hawks");

            Question question3 = new MultipleChoiceQuestion(possibleAnswers,
                                                            correctAnswers,
                                                            "What is the St Louis baseball team?",
                                                            2,
                                                            "multiplechoice",
                                                            1);

            questions.Add(question3);

            return quiz;
        }
    }
}
