using PRG547ASSIGNMENT1;

namespace PRG547ASSIGNMENT1.TEST
{
    public class Tests
    {
        private static readonly string[] NAMES = ["Liam", "Noah", "Oliver", "James", "Elijah", "Mateo", "Theodore", "Henry", "Lucas", "William", "Olivia", "Emma", "Charlotte", "Amelia", "Ava", "Mia", "Sophia", "Isla", "Harper", "Luna"];
        private static int LENGTH = 10;
        private Student[] Students = new Student[LENGTH];

        private readonly Student _toBeFound = new("ID 5", "The Program", "The Date", "The Name", "The Email", "The Phone");
        private readonly Student _notToBeFound = new("ID 50", "The Program", "The Date", "The Name", "The Email", "The Phone");

        private static void Shuffle<T>(T[] array)
        {
            Random random = new();
            var keys = array.Select(e => random.NextDouble()).ToArray();
            Array.Sort(keys, array);
        }

        [SetUp]
        public void Setup()
        {
            Random random = new();
            for (int i = 0; i < LENGTH; i++)
            {
                string _fName = NAMES[random.Next(0, NAMES.Length - 1)];
                string _lName = NAMES[random.Next(0, NAMES.Length - 1)];
                Students[i] = new Student($"ID {i}", $"Program {i}", $"20250301", $"{_fName} {_lName}", $"{_fName}.{_lName}@tafesa.com", $"+614{random.Next(10000000, 99999999)}");
            }
        }

        [Test]
        public void TestLinerSearchFound()
        {
            Assert.GreaterOrEqual(Utility.LinearSeachArray<Student>(Students, _toBeFound), 0);
        }
        [Test]
        public void TestLinerSearchNotFound()
        {

            Assert.Negative(Utility.LinearSeachArray<Student>(Students, _notToBeFound));
        }
        [Test]
        public void TestBinarySearchFound()
        {
            Assert.GreaterOrEqual(Utility.BinarySearchArray<Student>(Students, _toBeFound), 0);
        }
        [Test]
        public void TestBinarySearchNotFound()
        {
            Assert.Negative(Utility.BinarySearchArray<Student>(Students, _notToBeFound));
        }
        [Test]
        public void TestSortAsc()
        {
            Student[] _shuffle = (Student[])Students.Clone();
            Shuffle(_shuffle);
            TestContext.WriteLine("Student IDs after shuffle:");
            foreach (Student _s in _shuffle)
            {
                TestContext.WriteLine(_s.StudentID);
            }
            Utility.SortAsc(_shuffle);
            for (int i = 0; i < Students.Length; i++)
            {
                Assert.IsTrue(Students[i].Equals(_shuffle[i]));
            }
        }
        [Test]
        public void TestSortDesc()
        {
            Student[] _shuffle = (Student[])Students.Clone();
            Shuffle(_shuffle);
            TestContext.WriteLine("Student IDs after shuffle:");
            foreach (Student _s in _shuffle)
            {
                TestContext.WriteLine(_s.StudentID);
            }
            Utility.SortDesc(_shuffle);
            for (int i = 0; i < Students.Length; i++)
            {
                Assert.IsTrue(Students[i].Equals(_shuffle[Students.Length - 1 - i]));
            }
        }
    }
}