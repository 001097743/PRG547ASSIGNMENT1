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
            Console.WriteLine("[testing Student]");

            Console.WriteLine();
            Console.WriteLine("[testing getters, getters, ToString, GetHashCode]");

            Console.WriteLine();
            Console.WriteLine("> create object: studentNoArg");
            Student studentNoArg = new Student();

            Console.WriteLine();
            Console.WriteLine("> ToString()");
            Console.WriteLine(studentNoArg.ToString());

            Console.WriteLine();
            Console.WriteLine("> getters");
            Console.WriteLine($"StudentID: {studentNoArg.StudentID}");
            Console.WriteLine($"Program: {studentNoArg.Program}");
            Console.WriteLine($"DateRegister: {studentNoArg.DateRegistered}");
            Console.WriteLine($"GetHashCode: {studentNoArg.GetHashCode()}");

            Console.WriteLine();
            Console.WriteLine("> setters: set studentNoArg with (The Student, The Program, The Date)");
            studentNoArg.StudentID = "The Student";
            studentNoArg.Program = "The Program";
            studentNoArg.DateRegistered = "The Date";
            Console.WriteLine($"StudentID: {studentNoArg.StudentID}");
            Console.WriteLine($"Program: {studentNoArg.Program}");
            Console.WriteLine($"DateRegister: {studentNoArg.DateRegistered}");
            Console.WriteLine($"GetHashCode: {studentNoArg.GetHashCode()}");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("> now the studentNoArg is {The Student, The Program, The Date}");
            Console.WriteLine();
            Console.WriteLine("> create object: studentAllArg (The Other Student, The Other Program, The Other Date)");
            Console.WriteLine();
            Student studentAllArg = new Student("The Other Student", "The Other Program", "The Other Date");
            Console.WriteLine(studentAllArg.ToString());

            Console.WriteLine();
            Console.WriteLine("> create object same as ALL ARG: studentAllArgSame (The Other Student, The Other Program, The Other Date)");
            Console.WriteLine();
            Student studentAllArgSame = new Student("The Other Student", "The Other Program", "The Other Date");
            Console.WriteLine(studentAllArgSame.ToString());

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("[testing Equals, ==, !=]");

            Console.WriteLine();
            Console.WriteLine("> studentAllArg should be the same as studentAllArgSame");
            Console.WriteLine();
            Console.WriteLine($"> studentAllArg Equals studentAllArgSame (TRUE): {studentAllArg.Equals(studentAllArgSame)}");
            Console.WriteLine($"> studentAllArg == studentAllArgSame (TRUE): {studentAllArg == studentAllArgSame}");
            Console.WriteLine($"> studentAllArg != studentAllArgSame (FALSE): {studentAllArg != studentAllArgSame}");

            Console.WriteLine();
            Console.WriteLine("> studentNoArg should NOT be the same as studentAllArg");
            Console.WriteLine();
            Console.WriteLine($"> studentNoArg Equals studentAllArg (FALSE): {studentNoArg.Equals(studentAllArg)}");
            Console.WriteLine($"> studentNoArg == studentAllArg (FALSE): {studentNoArg == studentAllArg}");
            Console.WriteLine($"> studentNoArg != studentAllArg (TRUE): {studentNoArg != studentAllArg}");








            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
