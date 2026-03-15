// written by John
// 2/2/2026


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSpring2026
{
    public class AssociateStudent : Student 
    {
        // This will have all the public or protected properties and methods of Student
        // it will not have any private properties or private methods of Student

        public string FullName
        {
            get { return this.LastName + ", " + this.FirstName + " " + this.MiddleName; }
        }

        // Constructors
        // unfortunately you don't inherit constructors
        public AssociateStudent():this(-1, "n/a", "n/a", "n/a", "undecided")
        {
            // The empty Constructor
        }
        public AssociateStudent(int aStudentId, string aFirstName, string aLastName, string aMiddleName, string aMajor)
        {
            // This is called the full constructor
            this.StudentId = aStudentId;
            this.FirstName = aFirstName;
            this.LastName = aLastName;
            this.MiddleName = aMiddleName;
            this.Major = aMajor;
        }

        public override string ToString()
        {
            string message = "";
            message = message + "Student Type: Associate Student" + base.ToString() ;
            return message;
        }


    }
}
