using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sd2_mis4200_conroy.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<courseDetail> courseDetail { get; set; }
    }
}