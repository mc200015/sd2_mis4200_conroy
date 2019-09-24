using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sd2_mis4200_conroy.Models;
using System.Data.Entity;

namespace sd2_mis4200_conroy.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<courseDetail> courseDetail { get; set; }
    }
}