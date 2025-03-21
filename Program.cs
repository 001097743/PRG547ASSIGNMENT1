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

            C.Title("> create object: studentNoInfo");
            Student studentNoInfo = new Student("Person A", "pa@gmail.com", "0400 000 001");

            C.Title("> ToString()");
            C.Expected("" +
                "[Person]\n" +
                "Name: Person A\n" +
                "Email: pa@gmail.com\n" +
                "Phone Number: 0400 000 001\n" +
                "\n" +
                "All others: Not provided" +
                "");
            C.Actual(studentNoInfo.ToString());

            C.Next();

            C.Title("> getters");
            C.Expected("Same as studentNoInfo. Nothing provided except a Person");
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

            C.Title("> setters: set studentNoInfo with (The Student, The Program, The Date)");
            C.Expected("" +
                "[Student]\n" +
                "StudentID: The Student\n" +
                "Program: The Program\n" +
                "Date Register: The Date\n" +
                "\n" +
                "All others: Not provided" +
                "");

            studentNoInfo.StudentID = "The Student";
            studentNoInfo.Program = "The Program";
            studentNoInfo.DateRegistered = "The Date";
            C.Actual($"" +
                $"[Student]\n" +
                $"StudentID: {studentNoInfo.StudentID}\n" +
                $"Program: {studentNoInfo.Program}\n" +
                $"DateRegister: {studentNoInfo.DateRegistered}" +
                $"");

            C.Next();

            C.Title("> now the studentNoInfo is {The Student, The Program, The Date}");
            C.Title("> create object: studentWithInfo (The Other Student, The Other Program, The Other Date)");

            Student studentWithInfo = new Student(
                "The Other Student",
                "The Other Program",
                "The Other Date",
                "Person B",
                "pb@gmail.com",
                "0400 000 002"
                );

            C.Expected("" +
                "[Student]\n" +
                "StudentID: The Other Student\n" +
                "Program: The Other Program\n" +
                "Date Register: The Other Date\n" +
                "[Person]\n" +
                "Name: Person B\n" +
                "Email: pb@gmail.com\n" +
                "Phone Number: 0400 000 002\n" +
                "\n" +
                "All others: Not provided" +
                "");
            C.Actual(studentWithInfo.ToString());

            C.Next();

            C.Title("> create a same object studentWithInfoSame (The Other Student, The Other Program, The Other Date)");
            Student studentWithInfoSame = new Student("The Other Student", "The Other Program", "The Other Date", "Person B", "pb@gmail.com", "0400 000 002");
            C.Expected("" +
                "[Student]\n" +
                "StudentID: The Other Student\n" +
                "Program: The Other Program\n" +
                "Date Register: The Other Date\n" +
                "[Person]\n" +
                "Name: Person B\n" +
                "Email: pb@gmail.com\n" +
                "Phone Number: 0400 000 002\n" +
                "\n" +
                "All others: Not provided" +
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
        }
    }
}
