using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APISemana11A.Models
{
    public class Enrollment
    {
        public Enrollment
	    {
		    public int EnrollmentID { get; set; }
            public DateTime Date { get; set; }

            //Llave foranea

            public int CourseID { get; set; }
            public Course Course { get; set; }


            public int StudentID { get; set; }
            public Student Student { get; set; }

        }
    }
}

