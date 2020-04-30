using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JAQ_BackendDev.Models;
using JAQ_BackendDev.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JAQ_BackendDev.Web.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IQuizRepo _quizRepo;
        private readonly IQuestionRepo _questionRepo;
        private readonly IAnswerRepo _answerRepo;

        public QuizController(UserManager<AppUser> userManager, IQuizRepo quizRepository, IQuestionRepo questionRepo, IAnswerRepo answerRepo)
        {
            this._userManager = userManager;
            this._quizRepo = quizRepository;
            this._questionRepo = questionRepo;
            this._answerRepo = answerRepo;
        }

        // GET: Quiz
        public async Task<ActionResult> Quizzes()
        {
            var result = await _quizRepo.GetAllQuizesAsync();

            return View(result);
        }

        public async Task<ActionResult> MyQuizzes()
        {
            string usrid = _userManager.GetUserId(User);

            var result = await _quizRepo.GetQuizzesUser(usrid);

            return View(result);
        }

        public async Task<ActionResult> Questions(Guid quizid)
        {
            var result = await _questionRepo.GetQuestionsQuiz(quizid);
            var qz = await _quizRepo.GetQuizById(quizid);
            ViewBag.QuizName = qz.Name;
            ViewBag.QuizId = qz.Id;

            return View(result);
        }

        public async Task<ActionResult> Answers(Guid id)
        {
            var result = await _answerRepo.GetAnswersForQuestion(id);
            var question = await _questionRepo.GetQuestionByIdAsync(id);

            ViewBag.QstName = question.QuestionSelf;
            ViewBag.QstId = id;

            return View(result);
        }

        // GET: Quiz/Create
        public ActionResult CreateQuiz()
        {
            return View();
        }

        // POST: Quiz/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateQuiz(IFormCollection collection, Quiz quiz)
        {
            try
            {
                // TODO: Add insert logic here
                quiz.AppUserId = _userManager.GetUserId(User);
                var created = await _quizRepo.AddQuizAsync(quiz);
                if (created == null)
                {
                    throw new Exception("Invalid Entry.");
                }
                return RedirectToAction(nameof(MyQuizzes));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateQuestion(Guid quizid)
        {
            ViewBag.QuizId = quizid;
            return View();
        }

        // POST: Quiz/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateQuestion(IFormCollection collection, Question question)
        {
            try
            {
                // TODO: Add insert logic here
                var created = await _questionRepo.AddQuestionToQuiz(question);
                if (created == null)
                {
                    throw new Exception("Invalid Entry.");
                }
                return RedirectToAction("Questions", "Quiz", new { quizid = created.QuizId });
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> CreateAnswer(Guid questionid)
        {
            ViewBag.QstId = questionid;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAnswer(IFormCollection collection, Answer ans)
        {
            try
            {
                // TODO: Add insert logic here
                var created = await _answerRepo.AddAnswerToQuestion(ans);
                if (created == null)
                {
                    throw new Exception("Invalid Entry.");
                }
                return RedirectToAction("Answers", "Quiz", new { id = created.QuestionId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Quiz/Edit/5
        public ActionResult EditQuiz(int id)
        {
            return View();
        }

        // POST: Quiz/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditQuiz(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Quiz/Delete/5
        public async Task<ActionResult> DeleteQuiz(Guid id)
        {
            if (id == null)
                return BadRequest();

            var quiz = await _quizRepo.GetQuizById(id);

            return View(quiz);
        }

        // POST: Quiz/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteQuiz(Guid id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                await _quizRepo.DeleteQuizAsync(id);

                return RedirectToAction(nameof(MyQuizzes));
            }
            catch
            {
                return View();
            }
        }


        public async Task<ActionResult> DeleteQuestion(Guid id)
        {
            if (id == null)
                return BadRequest();

            var question = await _questionRepo.GetQuestionByIdAsync(id);

            return View(question);
        }

        // POST: Quiz/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteQuestion(Guid id, IFormCollection collection)
        {
            try
            {
                var qst = await _questionRepo.GetQuestionByIdAsync(id);
                // TODO: Add delete logic here
                await _questionRepo.DeleteQuestionAsync(id);

                return RedirectToAction("Questions", "Quiz", new { quizid = qst.QuizId });
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> DeleteAnswer(Guid id)
        {
            if (id == null)
                return BadRequest();

            var ans = await _answerRepo.GetAnswerByIdAsync(id);

            return View(ans);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAnswer(Guid id, IFormCollection collection)
        {
            try
            {
                var ans = await _answerRepo.GetAnswerByIdAsync(id);
                // TODO: Add delete logic here
                await _answerRepo.DeleteAnswerAsync(id);

                return RedirectToAction("Answers", "Quiz", new { id = ans.QuestionId });
            }
            catch
            {
                return View();
            }
        }

    }
}