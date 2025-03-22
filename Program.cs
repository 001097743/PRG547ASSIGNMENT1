using PRG547ASSIGNMENT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable

namespace PRG547ASSIGNMENT1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            C.Title("[testing getters, getters, ToString, GetHashCode]");

            C.Title("> create object: studentNoInfo: Person 1, p1@gmail.com, 0400 000 001");
            Student studentNoInfo = new Student("Person 1", "p1@gmail.com", "0400 000 001");

            C.Title("> ToString()");
            C.Expected("" +
                "[Person]\n" +
                "Name: Person 1\n" +
                "Email: p1@gmail.com\n" +
                "Phone Number: 0400 000 001\n" +
                "\n" +
                "");
            C.Actual(studentNoInfo.ToString());

            C.Next();

            C.Title("> getters");
            C.Expected("Same as studentNoInfo: Person 1, p1@gmail.com, 0400 000 001");
            C.Actual($"" +
                $"[Student]\n" +
                $"StudentID: {studentNoInfo.StudentID}\n" +
                $"Program: {studentNoInfo.Program}\n" +
                $"DateRegister: {studentNoInfo.DateRegistered}\n" +
                $"GetHashCode: {studentNoInfo.GetHashCode()}\n" +
                $"\n" +
                $"[Person]\n" +
                $"Name: {studentNoInfo.Name}\n" +
                $"Email: {studentNoInfo.Email}\n" +
                $"Phone Number: {studentNoInfo.PhoneNumber}" +
                $"");

            C.Next();

            C.Title("> setters: set studentNoInfo with: Person 1 mod, p1mod@gmail.com, 0400 111 001");
            C.Title("> setters: set studentNoInfo with: ID 1, Program 1, Date 1");
            C.Expected("" +
                "[Student]\n" +
                "StudentID: ID 1\n" +
                "Program: Program 1\n" +
                "Date Register: Date 1\n" +
                "[Person]\n" +
                "Name: Person 1 mod\n" +
                "Email: p1mod@gmail.com\n" +
                "Phone Number: 0400 111 001\n" +
                "\n" +
                "");

            studentNoInfo.StudentID = "ID 1";
            studentNoInfo.Program = "Program 1";
            studentNoInfo.DateRegistered = "Date 1";
            studentNoInfo.Name = "Person 1 mod";
            studentNoInfo.Email = "Person 1 mod@gmail.com";
            studentNoInfo.PhoneNumber = "0400 111 001";
            C.Actual(
                $"\n" +
                $"[Student]\n" +
                $"StudentID: {studentNoInfo.StudentID}\n" +
                $"Program: {studentNoInfo.Program}\n" +
                $"DateRegister: {studentNoInfo.DateRegistered}\n" +
                $"[Person]\n" +
                $"Name: {studentNoInfo.Name}\n" +
                $"Email: {studentNoInfo.Email}\n" +
                $"Phone Number: {studentNoInfo.PhoneNumber}\n" +
                $""
                );

            C.Next();

            C.Title("> Now studentNoInfo is: Person 1 mod, p1mod@gmail.com, 0400 111 001");
            C.Title("> With: ID 1, Program 1, Date 1");

            C.Title("> create object: studentWithInfo: ID 2, Program 2, Date 2, Person 2, p2@gmail.com, 0400 000 002");

            Student studentWithInfo = new Student(
                "ID 2",
                "Program 2",
                "Date 2",
                "Person 2",
                "p2@gmail.com",
                "0400 000 002"
                );

            C.Expected("" +
                "[Student]\n" +
                "StudentID: ID 2\n" +
                "Program: Program 2\n" +
                "Date Register: Date 2\n" +
                "[Person]\n" +
                "Name: Person 2\n" +
                "Email: p2@gmail.com\n" +
                "Phone Number: 0400 000 002\n" +
                "");
            C.Actual(studentWithInfo.ToString());

            C.Next();

            C.Title("> create a same object using same information as studentWithInfo: ID 2, Program 2, Date 2, Person 2, p2@gmail.com, 0400 000 002");
            C.Title("> studentWithInfoSame: ID 2, Program 2, Date 2, Person 2, p2@gmail.com, 0400 000 002");


            Student studentWithInfoSame = new Student(
                "ID 2",
                "Program 2",
                "Date 2",
                "Person 2",
                "p2@gmail.com",
                "0400 000 002"
                );

            C.Expected("" +
                "[Student]\n" +
                "StudentID: ID 2\n" +
                "Program: Program 2\n" +
                "Date Register: Date 2\n" +
                "[Person]\n" +
                "Name: Person 2\n" +
                "Email: p2@gmail.com\n" +
                "Phone Number: 0400 000 002\n" +
                "");
            C.Actual(studentWithInfoSame.ToString());

            C.Next();

            C.Title("[testing Equals, ==, !=]");
            C.Title("> studentWithInfo should be the same as studentWithInfoSame");

            C.Expected("studentWithInfo Equals studentWithInfoSame (TRUE)");
            C.Actual((studentWithInfo.Equals(studentWithInfoSame)).ToString());

            C.Expected("studentWithInfo == studentWithInfoSame(TRUE)");
            C.Actual((studentWithInfo == studentWithInfoSame).ToString());

            C.Expected("studentWithInfo != studentWithInfoSame (FALSE)");
            C.Actual((studentWithInfo != studentWithInfoSame).ToString());

            C.Title("studentNoInfo should NOT be the same as studentWithInfo");

            C.Expected("studentNoInfo Equals studentWithInfo (FALSE)");
            C.Actual((studentNoInfo.Equals(studentWithInfo)).ToString());

            C.Expected("studentNoInfo == studentWithInfo (FALSE)");
            C.Actual((studentNoInfo == studentWithInfo).ToString());

            C.Expected("studentNoInfo != studentWithInfo (TRUE)");
            C.Actual((studentNoInfo != studentWithInfo).ToString());

            C.Next();

            C.Title("> [Testing Student with Enrollment and Address]");
            Address address = new Address("Street Num testing", "Street Name testing", "Suburb testing", "Postcode testing", "State testing");
            Subject subject = new Subject("Subject Code testing", "Subject Name testing", 123);
            Enrollment enrollment = new Enrollment("Date Enrolled testing", "Grade testing", "Semester testing", subject);
            Student student = new Student(
                "Student ID testing",
                "Program testing",
                "Date Registered testing",
                "Name testing",
                "Email_testing@gmail.com",
                "Phone Number testing",
                address,
                enrollment
                );
            C.Expected($"" +
                "[Student]\n" +
                "StudentID: Student ID testing\n" +
                "Program: Program testing\n" +
                "Date Register: Date Registered testing\n" +
                "[Person]\n" +
                "Name: Name testing\n" +
                "Email: Email_testing@gmail.com\n" +
                "Phone Number: Phone Number testing\n" +
                "[Enrollment]\n" +
                "Date Enrolled: Date Enrolled testing\n" +
                "Grade: Grade testing\n" +
                "Semester: Semester testing\n" +
                "[Subject]\n" +
                "Subject Code: Subject Code testing\n" +
                "Subjcet Name: Subject Name testing\n" +
                "Cost: 123" +
                "\n"
                );
            C.Actual(student.ToString());

            C.Next();
        }
    }
}
