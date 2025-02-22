using NUnit.Framework;
using ConsoleApp;
using NUnit.Framework.Legacy;


namespace TestWebsiteProject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BubbleSort_SortsArrayCorrectly()
        {
            // Arrange
            int[] unsortedArray = { 64, 34, 25, 12, 22, 11, 90 };
            int[] expectedSortedArray = { 11, 12, 22, 25, 34, 64, 90 };

            // Act
            int[] sortedArray = CsharpTwelveDemo.BubbleSort(unsortedArray);

            // Assert
            CollectionAssert.AreEqual(expectedSortedArray, sortedArray);
        }


        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}