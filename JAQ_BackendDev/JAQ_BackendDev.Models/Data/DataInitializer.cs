using JAQ_BackendDev.Models.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
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

        public async Task AddQuiz()
        {
            AppUser usr = await _userMgr.FindByNameAsync("Victor@Creator");

            Quiz qz = new Quiz() { AppUserId = usr.Id, Name = "Weird Laws test", Description = "Strange Laws From Over The World", Diff = 0 };

            await _quizRepo.AddQuizAsync(qz);

            //Question q1 = new Question() { QuestionSelf = "In which country are only electricians allowed to change light bulbs ?", Type = 0 };
            //Question q2 = new Question() { QuestionSelf = "What is illegal on Germany's autobahns ?", Type = 0 };
            //Question q3 = new Question() { QuestionSelf = "Wearing what will get you told off at ancient sites in Greece ?", Type = 0 };
            //Question q4 = new Question() { QuestionSelf = "Where is chewing gum a no-go ? ", Type = 0 };
            //Question q5 = new Question() { QuestionSelf = "In Portugal it's illegal to urinate in the what ?", Type = 0 };
            //Question q6 = new Question() { QuestionSelf = "In which country is it illegal to step on currency ?", Type = 0 };
            //Question q7 = new Question() { QuestionSelf = "In Spain you'll receive a fine for driving in what ?", Type = 0 };
            //Question q8 = new Question() { QuestionSelf = "In the US state of Kentucky, women can wear a swimsuit while driving, but only if they carry...", Type = 0 };
            //Question q9 = new Question() { QuestionSelf = "Don't honk your car horn in Cyprus if you're...", Type = 0 };
            //Question q10 = new Question() { QuestionSelf = "In Barbados it's illegal to wear what?", Type = 0 };


            }

    }
}
