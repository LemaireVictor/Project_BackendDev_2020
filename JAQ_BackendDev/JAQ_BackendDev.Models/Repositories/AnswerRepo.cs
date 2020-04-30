using JAQ_BackendDev.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAQ_BackendDev.Models.Repositories
{
    public class AnswerRepo : IAnswerRepo
    {
        private readonly JAQ_BackendDevDbContext _context;

        public AnswerRepo(JAQ_BackendDevDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Answer>> GetAnswersForQuestion(Guid questionid)
        {
            try
            {
                var result = await _context.Answers.Where(a => a.QuestionId == questionid).ToListAsync();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Answer> AddAnswerToQuestion(Answer answer)
        {
            try
            {
                var result = await _context.Answers.AddAsync(answer);
                await _context.SaveChangesAsync();

                return answer;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Answer> GetAnswerByIdAsync(Guid id)
        {
            try
            {
                var result = await _context.Answers.SingleOrDefaultAsync(e => e.Id == id);

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteAnswerAsync (Guid id)
        {

            try
            {
                var result = await _context.Answers.SingleOrDefaultAsync(e => e.Id == id);
                _context.Answers.Remove(result);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
