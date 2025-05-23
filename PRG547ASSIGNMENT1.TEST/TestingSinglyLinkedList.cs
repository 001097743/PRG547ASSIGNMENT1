using PRG547ASSIGNMENT1;
using System.Xml.Linq;
using System;

namespace PRG547ASSIGNMENT1.TEST
{
    class TestingSinglyLinkedList
    {
        private static readonly string[] NAMES = ["Liam", "Noah", "Oliver", "James", "Elijah", "Mateo", "Theodore", "Henry", "Lucas", "William", "Olivia", "Emma", "Charlotte", "Amelia", "Ava", "Mia", "Sophia", "Isla", "Harper", "Luna"];
        private SinglyLinkedList<Student> STUDENTS;
 
        [SetUp]
        public void Setup()
        {
            STUDENTS = [];
            Random random = new();
            for (int i = 3; i > 0; i--)
            {
                string _fName = NAMES[random.Next(0, NAMES.Length - 1)];
                string _lName = NAMES[random.Next(0, NAMES.Length - 1)];
                Student _student = new ($"ID {i}", $"Program {i}", $"20250301", $"{_fName} {_lName}", $"{_fName}.{_lName}@tafesa.com", $"+614{random.Next(10000000, 99999999)}");
                STUDENTS.Add( _student );
            }
        }

        [Test]
        public void TestingAddToHead()
        {
            Student _student_for_head = new ("ID 99", $"Program Testing", "20250301", "John Citizen", "John.Citizen@tafesa.com", "+61400000099");

            TestContext.WriteLine("Before adding HEAD");
            foreach (Student student in STUDENTS)
            {
                TestContext.WriteLine(student.StudentID);
            }
            STUDENTS.AddFirst(_student_for_head);
            TestContext.WriteLine("After adding HEAD: expected ID 99 added to first");
            foreach (Student student in STUDENTS)
            {
                TestContext.WriteLine(student.StudentID);
            }
        }
        [Test]
        public void TestingAddToTail()
        {
            Student _student_for_tail = new ("ID 00", "Program", "20250301", "John Citizen", "John.Citizen@tafesa.com", "+61400000000");

            TestContext.WriteLine("Before adding TAIL");
            foreach (Student student in STUDENTS)
            {
                TestContext.WriteLine(student.StudentID);
            }
            STUDENTS.AddLast(_student_for_tail);
            TestContext.WriteLine("After adding TAIL: expected ID 00 added to last");
            foreach (Student student in STUDENTS)
            {
                TestContext.WriteLine(student.StudentID);
            }
        }
        [Test]
        public void TestingContainsFound()
        {
            Student _student_to_be_found = new("ID 2", "Program", "Date", "Name", "Email", "Phone");
            Assert.IsTrue(STUDENTS.Contains(_student_to_be_found));
        }
        [Test]
        public void TestingContainsNotFound()
        {
            Student _student_not_to_be_found = new("ID 9", "Program", "Date", "Name", "Email", "Phone");
            Assert.IsFalse(STUDENTS.Contains(_student_not_to_be_found));
        }
        [Test]
        public void TestingRemoveHead()
        {
            TestContext.WriteLine("Before removing first");
            foreach (Student student in STUDENTS)
            {
                TestContext.WriteLine(student.StudentID);
            }

            TestContext.WriteLine("After removing first: Expected ID 1 gone");
            STUDENTS.RemoveFirst();
            foreach (Student student in STUDENTS)
            {
                TestContext.WriteLine(student.StudentID);
            }
        }
        [Test]
        public void TestingRemoveTail()
        {
            TestContext.WriteLine("Before removing last");
            foreach (Student student in STUDENTS)
            {
                TestContext.WriteLine(student.StudentID);
            }

            TestContext.WriteLine("After removing last: Expected ID 3 gone");
            STUDENTS.RemoveLast();
            foreach (Student student in STUDENTS)
            {
                TestContext.WriteLine(student.StudentID);
            }
        }
    }
}
