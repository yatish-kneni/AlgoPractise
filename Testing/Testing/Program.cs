using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestMergeSort();
        }

        static void TestLis()
        {
            int[] testLISArray = new[] { 5, 2, 8, 6, 3, 6, 9, 7 };
            int[] testLISArray2 = new[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };
            var l = new LIS();
            var result = l.Execute(testLISArray2);
            Console.ReadLine();
        }

        static void TestKnapsack()
        {
            int[] popu = new[] { 100, 30, 200, 250, 700 };
            int[] votes = new[] { 1, 2, 5, 6, 7 };
            int Z = 12;
            var tb = new Knapsack();
            var result = tb.ElectoralVotes(popu, votes, Z);
            Console.ReadLine();
        }

        static void TestMovement()
        {
            var m = new Movement();
            var result = m.Move(16);
            Console.ReadLine();
        }

        static void TestBinarySearch()
        {
            var b = new BinarySearch();
            var testinput = new int[] { 10, 23, 36, 47, 59, 64, 71, 82, 95, 100, 116, 127, 138, 141, 152, 163 };
            var result = b.BinarySearchImpl(testinput, testinput.Length, 0, 36);
            Console.ReadLine();
        }

        static void TestMissing()
        {
            var t = new MissingElement();
            var testI = new int[] { 1, 3, 4, 6 };
            var testI2 = new int[] { 1, 2, 3, 4, 6 };
            var testI3 = new int[] { 1, 2, 3, 4, 5, 6 };
            var result = t.Missing(testI3);
            Console.ReadLine();
        }

        static void TestMergeSort()
        {
            var t = new MergeSort();
            var testI = new int[] { 12, 12, 23, 4, 6, 6, 10, -35, 28 };
            int[] test2 = { 12, 12, 12, 12, 12 };

            var result = t.PerformMergeSort(testI);
            var result2 = t.PerformMergeSort(test2);
            Console.ReadLine();
        }
    }
}
