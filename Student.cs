using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

#pragma warning disable

namespace PRG547ASSIGNMENT1
{
    internal class Student : Person
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
        public Address StudentAddress { get; set; }
        public Enrollment Enrollment { get; set; }

        /// <summary>
        /// All Arg Student
        /// </summary>
        /// <param name="studentID">Student ID</param>
        /// <param name="program">Program</param>
        /// <param name="dateRegistered">Date Registered</param>
        /// <param name="name">Name</param>
        /// <param name="email">Email Address</param>
        /// <param name="phoneNumber">Phone Number</param>
        /// <param name="address">Address Class</param>
        /// <param name="enrollment">Enrollment Class</param>
        public Student(
            string studentID,
            string program,
            string dateRegistered,
            string name,
            string email,
            string phoneNumber,
            Address address,
            Enrollment enrollment
            ) : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
            base.Name = name;
            base.Email = email;
            base.PhoneNumber = phoneNumber;
            base.Address = address;
        }

        /// <summary>
        /// Partial Arg Student - Person only
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="email">Email Address</param>
        /// <param name="phoneNumber">Phone Number</param>
        public Student(string name, string email, string phoneNumber) : base(name, email, phoneNumber)
        {
            StudentID = DEF_STUDENT_ID;
            Program = DEF_PROGRAM;
            DateRegistered = DEF_DATE_REGISTERED;
            base.Name = name;
            base.Email = email;
            base.PhoneNumber = phoneNumber;
            Enrollment = new Enrollment();
        }

        /// <summary>
        /// Partial Arg Student - Person and student info
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="email">Email Address</param>
        /// <param name="phoneNumber">Phone Number</param>
        public Student(
            string studentID,
            string program,
            string dateRegistered,
            string name,
            string email,
            string phoneNumber
            ) : base(name, email, phoneNumber)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = name;
            base.Name = name;
            base.Email = email;
            base.PhoneNumber = phoneNumber;
            Enrollment = new Enrollment();
        }

        /// <summary>
        /// Partial Arg Student - Person and student info and enrollment
        /// </summary>
        /// <param name="studentID">Student ID</param>
        /// <param name="program">Program</param>
        /// <param name="dateRegistered">Date Registered</param>
        /// <param name="name">Name</param>
        /// <param name="email">Email Address</param>
        /// <param name="phoneNumber">Phone Number</param>
        /// <param name="enrollment">Enrollment Class</param>
        public Student(
            string studentID,
            string program,
            string dateRegistered,
            string name,
            string email,
            string phoneNumber,
            Enrollment enrollment
            ) : base(name, email, phoneNumber)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = name;
            base.Name = name;
            base.Email = email;
            base.PhoneNumber = phoneNumber;
            Enrollment = enrollment;
        }

        /// <summary>
        /// Partial Arg Student - Person and student info and address
        /// </summary>
        /// <param name="studentID">Student ID</param>
        /// <param name="program">Program</param>
        /// <param name="dateRegistered">Date Registered</param>
        /// <param name="name">Name</param>
        /// <param name="email">Email Address</param>
        /// <param name="phoneNumber">Phone Number</param>
        /// <param name="address">Address Class</param>
        public Student(
            string studentID,
            string program,
            string dateRegistered,
            string name,
            string email,
            string phoneNumber,
            Address address
            ) : base(name, email, phoneNumber)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = name;
            base.Name = name;
            base.Email = email;
            base.PhoneNumber = phoneNumber;
            Address = address;
        }

        /// <summary>
        /// Override ToString()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return $"\n" +
                $"[Student]\n" +
                $"Student ID: {StudentID}\n" +
                $"Program: {Program}\n" +
                $"Date Registered: {DateRegistered};\n" +
                $"{base.ToString()}\n" +
                $"{Enrollment}\n" +
                $"";
        }

        /// <summary>
        /// Override virtual Equals()
        /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/override
        /// </summary>
        /// <param name="obj">Object for comparing</param>
        /// <returns>bool</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(obj, this)) return true;
            Student student = (Student)obj;
            return obj.GetType() == this.GetType() && student.StudentID == StudentID;
        }

        /// <summary>
        /// Override static Equals()
        /// </summary>
        /// <param name="a">Object for comparing</param>
        /// <param name="b">Object for comparing</param>
        /// <returns>bool</returns>
        public static bool Equals(object a, object b)
        {
            if (a == b) return true;
            return !(a == null || b == null) && a.Equals(b);
        }

        /// <summary>
        /// Overload operator ==
        /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
        /// </summary>
        /// <param name="a">Object for comparing</param>
        /// <param name="b">Object for comparing</param>
        /// <returns>bool</returns>
        public static bool operator ==(Student a, Student b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// Overload operator !=
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>bool</returns>
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Override GetHashCode()
        /// </summary>
        /// <returns>int</returns>
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }

    }
}
