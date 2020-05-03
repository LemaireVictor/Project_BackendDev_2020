using JAQ_BackendDev.Models.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAQ_BackendDev.Models.Data
{
    public class DataInitializer : IDataInitializer
    {

        private readonly IQuizRepo _quizRepo;
        private readonly IQuestionRepo _questionRepo;
        private readonly IAnswerRepo _answerRepo;
        private readonly UserManager<AppUser> _userMgr;

        public DataInitializer(IQuizRepo quizrepo, IQuestionRepo questionRepo, IAnswerRepo answerRepo, UserManager<AppUser> userMgr)
        {
            this._quizRepo = quizrepo;
            this._questionRepo = questionRepo;
            this._answerRepo = answerRepo;

            this._userMgr = userMgr;
        }

        public async Task InitQuizzes()
        {
            if (await _userMgr.FindByEmailAsync("Docent@MCT.be") != null)
            {
                var usr = await _userMgr.FindByEmailAsync("Docent@MCT.be");
                if (await _quizRepo.GetQuizByNameAsync("Weird Laws") == null)
                {
                    var quiz1 = new Quiz()
                    {
                        Name = "Weird Laws",
                        Description = "Quiz About Wierd Laws Over The World",
                        Diff = 0,
                        AppUserId = usr.Id
                    };

                    Quiz quizMade = await _quizRepo.AddQuizAsync(quiz1);

                    List<String> qstList1 = new List<string> {
                        "In which country are only electricians allowed to change light bulbs ?",
                        "What is illegal on Germany's autobahns ?",
                        "Wearing what will get you told off at ancient sites in Greece ?",
                        "Where is chewing gum a no-go ?",
                        "In Portugal it's illegal to urinate in the what ?",
                        "In which country is it illegal to step on currency ?",
                        "In Spain you'll receive a fine for driving in what ?",
                        "In the US state of Kentucky, women can wear a swimsuit while driving, but only if they carry... ",
                        "Don't honk your car horn in Cyprus if you're...",
                        "In Barbados it's illegal to wear what ?"};

                    List<List<string>> ansList = new List<List<string>> {
                        new List<string>{"Kazakhstan","Belgium","Colombia","Australia", "3"},
                        new List<string>{"Running out of fuel"," Driving With windows down","Singing while driving","using your hazard warning lights", "0"},
                        new List<string>{"Foam fingers","High heels","Signet rings","Baseball caps", "1"},
                        new List<string>{"Texas","Vatican City","Switzerland","Singapore", "3"},
                        new List<string>{"Sea","Shower","Sink","Your neighbour's toilet", "0"},
                        new List<string>{"Saudi Arabia","Wales","Papua New Guinea","Thailand", "3"},
                        new List<string>{"Russian-made car","A Portugal football shirt","Flip flops","Both a hat and sunglasses", "2"},
                        new List<string>{"A crucifix"," A sarong","A bumbag","An self-defence object", "3"},
                        new List<string>{"Near a hospital","By a beach","Wearing a vest","Driving before 7am", "0"},
                        new List<string>{"Leopard print","A tie","Camouflage clothing","More than one hat", "2"}
                    };

                    for (int i = 0; i < qstList1.Count; i++)
                    {
                        Question qst = new Question()
                        {
                            QuestionSelf = qstList1[i],
                            QuizId = quizMade.Id,
                            Type = 0,
                        };

                        // create Question
                        var resultqst = await _questionRepo.AddQuestionToQuiz(qst);

                        for (int a = 0; a < 4; a++)
                        {
                            if (a == int.Parse(ansList[i][4]))
                            {
                                Answer ans = new Answer()
                                {
                                    IsCorrect = true,
                                    Answer_Text = ansList[i][a],
                                    QuestionId = qst.Id
                                };
                                var resultans = await _answerRepo.AddAnswerToQuestion(ans);
                            }

                            else
                            {
                                Answer ans = new Answer()
                                {
                                    IsCorrect = false,
                                    Answer_Text = ansList[i][a],
                                    QuestionId = qst.Id

                                };
                                var resultans = await _answerRepo.AddAnswerToQuestion(ans);
                            }

                        }


                    }

                }
            }
        }

    }
}
