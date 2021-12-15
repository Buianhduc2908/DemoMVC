using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data{
      public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }

        
         public DbSet<Student> Student  { get; set; }
         public DbSet<MvcMovie.Models.Employee> Employee { get; set; }
         public DbSet<MvcMovie.Models.Product> Product { get; set; }
         public DbSet<Person> People { get; set; }
    }
}


