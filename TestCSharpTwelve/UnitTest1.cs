using ConsoleApp;

namespace TestCSharpTwelve
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 64, 34, 25, 12, 22, 11, 90 }, new int[] { 11, 12, 22, 25, 34, 64, 90 })]
        [TestCase(new int[] { 5, 3, 8, 4, 2 }, new int[] { 2, 3, 4, 5, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 9, 7, 5, 3, 1 }, new int[] { 1, 3, 5, 7, 9 })]
        [TestCase(new int[] { }, new int[] { })]
        public void BubbleSort_SortsArrayCorrectly(int[] unsortedArray, int[] expectedSortedArray)
        {
            // Act
            int[] sortedArray = CsharpTwelveDemo.BubbleSort(unsortedArray);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, sortedArray);
        }


    }
}