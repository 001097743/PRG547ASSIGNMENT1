using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;

namespace PRG547ASSIGNMENT1
{
    internal class Student
    {
        const string DEF_STUDENT_ID = "Not provided";
        const string DEF_PROGRAM = "Not provided";
        const string DEF_DATE_REGISTERED = "Not provided";

        /// <summary>
        /// Getters and setters
        /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        /// </summary>
        public string StudentID { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        /// <summary>
        /// All arg constructor
        /// </summary>
        /// <param name="studentID">Student ID</param>
        /// <param name="program">Program</param>
        /// <param name="dateRegistered">Date Registered</param>
        public Student(string studentID, string program, string dateRegistered)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        }
        /// <summary>
        /// No arg constructor
        /// </summary>
        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED) { }

        /// <summary>
        /// Override ToString()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() { return $"Student ID: {StudentID};\nProgram: {Program};\nDate Registered: {DateRegistered};"; }

        /// <summary>
        /// Override Equals()
        /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(obj, this)) return true;
            Student student = (Student)obj;
            return obj.GetType() == this.GetType() && student.StudentID == StudentID;
        }

        /// <summary>
        /// Overload operators ==, !=
        /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
        /// </summary>
        /// <param name="a">Object for </param>
        /// <param name="b"></param>
        /// <returns>bool</returns>
        public static bool operator ==(Student a, Student b) { return a.Equals(b); }
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
            // same??? !a.Equals(b);
        }

        /// <summary>
        /// Override GetHashCode()
        /// </summary>
        /// <returns>int</returns>
        public override int GetHashCode() { return StudentID.GetHashCode(); }

    }
}
