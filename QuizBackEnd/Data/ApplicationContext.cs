using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizBackEnd.Models;

namespace QuizBackEnd.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Questions> Questions { get; set; }
    }
}
