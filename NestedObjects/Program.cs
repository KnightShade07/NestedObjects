using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInst = new Instructor()
            {
                FullName = "Ken Meerdink",
                Email = "Ken.Meerdink@cptc.edu"
            };

            Student s1 = new Student()
            {
                FirstName = "Ethen",
                LastName = "Oliva"
            };

            Student s2 = new Student()
            {
                FirstName = "Kyran",
                LastName = "Perdue"
            };

            Student s3 = new Student()
            {
                FirstName = "John",
                LastName = "Uthus"
            };

            Course testCourse = new Course();
            testCourse.Title = "CPW 245 - Data and Logic Structures";
            testCourse.Description = "More Java, cause that's what you'll need to stay up at 12 AM at night while studying this course!";
            testCourse.Credits = 5;
            testCourse.ClassInstructor = currInst;
            testCourse.ClassRoster = new List<Student>();

            //Adding students to course.
            testCourse.ClassRoster.Add(s1);
            testCourse.ClassRoster.Add(s2);
            testCourse.ClassRoster.Add(s3);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine("Is taught by: " + testCourse.ClassInstructor.FullName);
            Console.WriteLine("He can be reached at: " + testCourse.ClassInstructor.Email);
            Console.WriteLine("This course is worth: " + testCourse.Credits);
            Console.WriteLine("Currently enrolled students: ");

            foreach(Student s in testCourse.ClassRoster)
            {
                Console.WriteLine(s.FirstName + " " + s.LastName);
            }
            Console.ReadKey();
        }
    }
}
