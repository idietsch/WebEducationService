using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebEducationService.Models;

namespace WebEducationService.Data
{
    public class EdDbContext : DbContext {
        public EdDbContext (DbContextOptions<EdDbContext> options)
            : base(options)
        {
        }

        public DbSet<Major> Majors { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Class> Class { get; set; }

        public DbSet<WebEducationService.Models.Student_Class> Student_Class { get; set; }


    }
}
