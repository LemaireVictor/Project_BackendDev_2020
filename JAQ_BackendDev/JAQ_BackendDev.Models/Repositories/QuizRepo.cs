﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JAQ_BackendDev.Web.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace JAQ_BackendDev.Models.Repositories
{
    public class QuizRepo : IQuizRepo
    {
        private readonly JAQ_BackendDevDbContext _context;

        public QuizRepo(JAQ_BackendDevDbContext context)
        {
            this._context = context;
        }

        // read

        public async Task<IEnumerable<Quiz>> GetAllQuizesAsync()
        {
            try
            {
                var result = await _context.Quizzes.Include(q => q.Questions).ThenInclude(q => q.Answers).ToListAsync<Quiz>();
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException.Message);
                return null;
            }
            
        }

        public async Task<IEnumerable<Quiz>> GetQuizzesUser(string appuserId)
        {
            try
            {
                var result = await _context.Quizzes.Where(q => q.AppUserId == appuserId).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException.Message);
                return null;
            }
        }

        public async Task<Quiz> GetQuizById(Guid id)
        {
            try
            {
                var result = await _context.Quizzes.SingleOrDefaultAsync(q => q.Id == id);

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //create

        public async Task<Quiz> AddQuizAsync(Quiz quiz)
        {
            try
            {
                var result = await _context.Quizzes.AddAsync(quiz);
                await _context.SaveChangesAsync();
                return quiz;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException.Message);
                return null;
            }

        }

        //delete 

        public async Task DeleteQuizAsync(Guid id)
        {
            try
            {
                var result = await _context.Quizzes.Where(q => q.Id == id).Include(q => q.Questions).ThenInclude(q => q.Answers).ToListAsync();

                _context.Quizzes.RemoveRange(result);
                

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException.Message);
            }
            return;
        }
    }
}