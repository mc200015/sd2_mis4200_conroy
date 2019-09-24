using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sd2_mis4200_conroy.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string description { get; set; }
        public DateTime courseDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<courseDetail> courseDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}