using System;
using System.Collections.Generic;
using System.Text;
using JAQ_BackendDev.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JAQ_BackendDev.Web.Data
{
    public class JAQ_BackendDevDbContext : IdentityDbContext<IdentityUser>
    {
        public JAQ_BackendDevDbContext(DbContextOptions<JAQ_BackendDevDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Quiz> Quizzes { get; set; }
        public virtual DbSet<Scores> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //must voor identity

            modelBuilder.Entity<Scores>().HasKey(e => new { e.AppUserId, e.QuizId });
        }



    }
}
