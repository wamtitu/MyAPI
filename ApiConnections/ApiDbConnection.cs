using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.ApiConnections
{
    public class ApiDbConnection : DbContext
    {
       public DbSet<Course> Courses { get; set; }
       public DbSet<Instructor> Instructors { get; set; }
        public ApiDbConnection(DbContextOptions<ApiDbConnection> options):base(options){}
    }
}