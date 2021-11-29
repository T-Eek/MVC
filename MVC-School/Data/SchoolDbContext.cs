using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_School.Models;

namespace MVC_School.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Studenten { get; set; }
        public DbSet<Docent> Docent { get; set; }
        public DbSet<Vak> Vak { get; set; }
        public DbSet<Locatie> Locaties{ get; set; }
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        
    }
}
