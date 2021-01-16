using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corewebapi.Model
{
    public class CourseContext : DbContext
    {
        // Replace your connecting string
        readonly string connectionstring = "Server=tcp:demoapi.database.windows.net,1433;Initial Catalog=demoapi;Persist Security Info=False;User ID=demoapi;Password=temp!123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(connectionstring);
            base.OnConfiguring(options);
        }
    }

    
}
