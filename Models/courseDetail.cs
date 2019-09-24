using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sd2_mis4200_conroy.Models
{
    public class courseDetail
    {
        public int coursedetailID { get; set; }
        public int courseDescription { get; set; }
        // public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
}
}