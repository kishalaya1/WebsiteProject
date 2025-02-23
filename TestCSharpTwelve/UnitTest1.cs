using ConsoleApp;
using System.Collections;

namespace TestCSharpTwelve
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public static IEnumerable BubbleSortTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 64, 34, 25, 12, 22, 11, 90 }, new int[] { 11, 12, 22, 25, 34, 64, 90 });
                yield return new TestCaseData(new int[] { 5, 3, 8, 4, 2 }, new int[] { 2, 3, 4, 5, 8 });
                yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 });
                yield return new TestCaseData(new int[] { 9, 7, 5, 3, 1 }, new int[] { 1, 3, 5, 7, 9 });
                yield return new TestCaseData(new int[] { }, new int[] { });
            }
        }

        [Test, TestCaseSource(nameof(BubbleSortTestCases))]
        public void BubbleSort_SortsArrayCorrectly(int[] unsortedArray, int[] expectedSortedArray)
        {
            // Act
            int[] sortedArray = CsharpTwelveDemo.BubbleSort(unsortedArray);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, sortedArray);
        }


    }
}