using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// This class represents an instructor for a particular course.
    /// </summary>
    class Instructor
    {
        /// <summary>
        /// Legal full name, first and last.
        /// Example: John Doe
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The person's email address.
        /// Example: John.Doe@yahoo.com
        /// </summary>

        public string Email { get; set; }
    }
}
