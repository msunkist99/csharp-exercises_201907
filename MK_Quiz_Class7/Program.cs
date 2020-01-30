using System;
using System.Collections.Generic;

namespace MK_Quiz_Class7
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = BuildQuizQuestions();
            //DisplayQuizQuestions(quiz);

            foreach (Question question in quiz.Questions)
            {
                DisplayQuestion(question);
                List<string> userAnswers = GetUserAnswer(question);
                quiz.ThisQuizScore += ScoreUserAnswer(question, userAnswers);
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
                                                       "TRUE", 
                                                       "True", 
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

        static void DisplayQuizQuestions(Quiz quiz)
        {
            foreach (Question question in quiz.Questions)
            {
                Console.WriteLine(question.ToString());
            }
        }

        static void DisplayQuestion(Question question)
        {
            switch (question.Type)
            {
                case "checkbox":
                    CheckboxQuestion checkboxQuestion = (CheckboxQuestion)question;
                    Console.WriteLine(checkboxQuestion.ToString());
                    break;

                case "truefalse":
                    TrueFalseQuestion trueFalseQuestion = (TrueFalseQuestion)question;
                    Console.WriteLine(trueFalseQuestion.ToString());
                    break;

                default:
                    MultipleChoiceQuestion multipleChoiceQuestion = (MultipleChoiceQuestion)question;
                    Console.WriteLine(multipleChoiceQuestion.ToString());
                    break;
            }
        }

        static List<string> GetUserAnswer(Question question)
        {
            List<string> answers = new List<string>();

            switch (question.Type)
            {
                case "checkbox":
                    CheckboxQuestion checkboxQuestion = (CheckboxQuestion)question;
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
                    break;

                case "truefalse":
                    TrueFalseQuestion trueFalseQuestion = (TrueFalseQuestion)question;
                    answers.Add(Console.ReadLine().ToUpper());
                    break;

                default:
                    MultipleChoiceQuestion multipleChoiceQuestion = (MultipleChoiceQuestion)question;
                    answers.Add(Console.ReadLine().ToUpper()); 
                    break;
            }

            return answers;
        }

        static int ScoreUserAnswer(Question question, List<string> answers)
        {
            int userQuestionScore = 0;

            switch (question.Type)
            {
                case "checkbox":
                    CheckboxQuestion checkboxQuestion = (CheckboxQuestion)question;
                    userQuestionScore = checkboxQuestion.CheckAnswer(answers);
                    break;

                case "truefalse":
                    TrueFalseQuestion trueFalseQuestion = (TrueFalseQuestion)question;
                    userQuestionScore = trueFalseQuestion.CheckAnswer(answers[0]);
                    break;

                default:
                    MultipleChoiceQuestion multipleChoiceQuestion = (MultipleChoiceQuestion)question;
                    userQuestionScore = multipleChoiceQuestion.CheckAnswer(answers[0]);
                    break;
            }

            Console.WriteLine($"User score - {userQuestionScore}");
            return userQuestionScore;
        }
    }
}
