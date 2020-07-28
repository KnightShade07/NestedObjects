using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        /// <summary>
        /// Title of the Course
        /// Example: CPW 245 - Data and Logic Structures
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description of the course.
        /// </summary>

        public string Description { get; set; }

        /// <summary>
        /// Amount of credits received upon completion of the course.
        /// </summary>

        public byte Credits { get; set; }

        /// <summary>
        /// The instructor responsible for the course.
        /// </summary>

        public Instructor ClassInstructor { get; set; }

        /// <summary>
        /// List of all students currently in a given course.
        /// </summary>
        public List<Student> ClassRoster { get; set; }




    }
}
