using Microsoft.SqlServer.Server;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace StudentManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

       

    }

}
    