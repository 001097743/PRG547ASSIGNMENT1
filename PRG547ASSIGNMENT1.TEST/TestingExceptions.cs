using PRG547ASSIGNMENT1;
using System.Xml.Linq;
using System;

namespace PRG547ASSIGNMENT1.TEST
{
    [TestFixture]
    class TestingExceptions
    {
        private static readonly string[] NAMES = ["Liam", "Noah", "Oliver", "James", "Elijah", "Mateo", "Theodore", "Henry", "Lucas", "William", "Olivia", "Emma", "Charlotte", "Amelia", "Ava", "Mia", "Sophia", "Isla", "Harper", "Luna"];
        private static readonly int LENGTH = 3;
        private readonly Student[] STUDENTS = new Student[LENGTH];
        private readonly Student _the_student = new("ID 1", "The Program", "The Date", "The Name", "The Email", "The Phone");

        [SetUp]
        public void Setup()
        {
            Random random = new();
            for (int i = 0; i < LENGTH; i++)
            {
                string _fName = NAMES[random.Next(0, NAMES.Length - 1)];
                string _lName = NAMES[random.Next(0, NAMES.Length - 1)];
                STUDENTS[i] = new Student($"ID {i}", $"Program {i}", $"20250301", $"{_fName} {_lName}", $"{_fName}.{_lName}@tafesa.com", $"+614{random.Next(10000000, 99999999)}");
            }
        }

        [Test]
        public void TestingExceptionLinearSearch()
        {
            TestContext.WriteLine("An exception is expected.");
            Assert.Catch<Exception>(() => { Utility.LinearSeachArray(STUDENTS, _the_student); });
        }

        [Test]
        public void TestingExceptionBinarySearch()
        {
            TestContext.WriteLine("An exception is expected.");
            Assert.Catch<Exception>(() => { Utility.BinarySearchArray(STUDENTS, _the_student); });
        }
    }
}
