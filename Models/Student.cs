using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sd2_mis4200_conroy.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime studentSince { get; set; }
        public ICollection<Course> Course { get; set; }

    }
}