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

        public string StudentID { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        public Student(string studentID, string program, string dateRegistered)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        }

        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEF_DATE_REGISTERED) { }

        public override string ToString() { return $"Student ID: {StudentID};\nProgram: {Program};\nDate Registered: {DateRegistered};"; }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(obj, this)) return true;
            Student student = (Student)obj;
            return obj.GetType() == this.GetType() && student.StudentID == StudentID;
        }

        public static bool operator ==(Student a, Student b) { return a.Equals(b); }
        public static bool operator !=(Student a, Student b) { return !(a == b); }
        //public static bool operator !=(Student a, Student b) { return !a.Equals(b); }
        public override int GetHashCode() { return StudentID.GetHashCode(); }

    }
}
