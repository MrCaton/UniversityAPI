using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<API.Models.Enrollment> Universities { get; set; }
        public DbSet<Course> Courses { get; set; }

        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options) { }
    }
}
