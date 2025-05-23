using PRG547ASSIGNMENT1;
using System;

namespace PRG547ASSIGNMENT1.TEST
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.SingleInstance)]
    class TestingBinaryTree
    {
        private static readonly string[] IDS = ["ID 4", "ID 6", "ID 2", "ID 5", "ID 3", "ID 1", "ID 7"];
        private static readonly BinaryTree<string> STUDENT_IDS= new();


        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine($"Original order of Student IDs:");
            TestContext.WriteLine(String.Join(", ", IDS));
            TestContext.WriteLine();
            foreach (string id in IDS) { STUDENT_IDS.Add(id); }

        }

        [Test]
        public void TestingPreOrder()
        {
            TestContext.WriteLine("Expected output: 4,2,1,3,6,5,7");
            TestContext.WriteLine("Ouput:");
            STUDENT_IDS.TraversePreOrder(STUDENT_IDS.Root);

        }

        [Test]
        public void TestingInOrder()
        {
            TestContext.WriteLine("Expected output: 1,2,3,4,5,6,7");
            TestContext.WriteLine("Ouput:");
            STUDENT_IDS.TraverseInOrder(STUDENT_IDS.Root);
        }

        [Test]
        public void TestingPostOrder()
        {
            TestContext.WriteLine("Expected output: 1,3,2,5,7,6,4");
            TestContext.WriteLine("Ouput:");
            STUDENT_IDS.TraversePostOrder(STUDENT_IDS.Root);
        }
    }
}
