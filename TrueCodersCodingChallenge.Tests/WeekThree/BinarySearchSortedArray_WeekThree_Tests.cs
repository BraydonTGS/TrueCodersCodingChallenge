using TrueCodersCodingChallenge.Console.WeekThree;
using TrueCodersCodingChallenge.Console.WeekTwo;

namespace TrueCodersCodingChallenge.Tests.WeekThree
{
    [TestClass]
    public class BinarySearchSortedArray_WeekThree_Tests
    {
        [TestMethod]
        public void BinarySearchOnASortedArray_Success()
        {
            var array = GenerateSortedArray();

            var index = BinarySearchSortedArray_WeekThree.BinarySearchOnASortedArray(array, 8);

            Assert.AreEqual(4, index);

        }

        [TestMethod]
        public void BinarySearchOnASortedArray_ItemNotFound_ReturnsNegativeOne_Success()
        {
            var array = GenerateSortedArray();

            var index = BinarySearchSortedArray_WeekThree.BinarySearchOnASortedArray(array, 1);

            Assert.AreEqual(-1, index);

        }

        [TestMethod]
        public void BinarySearchImplementation_Success()
        {
            var array = GenerateSortedArray();

            var index = BinarySearchSortedArray_WeekThree.BinarySearchImplementation(array, 8);

            Assert.AreEqual(4, index);

        }

        [TestMethod]
        public void BinarySearchImplementation_ItemNotFound_ReturnsNegativeOne_Success()
        {
            var array = GenerateSortedArray();

            var index = BinarySearchSortedArray_WeekThree.BinarySearchImplementation(array, 1);

            Assert.AreEqual(-1, index);

        }

        public int[] GenerateSortedArray()
        {
            // Creates and initializes a new Array.
            Array myIntArray = Array.CreateInstance(typeof(int), 5);

            myIntArray.SetValue(8, 0);
            myIntArray.SetValue(2, 1);
            myIntArray.SetValue(6, 2);
            myIntArray.SetValue(3, 3);
            myIntArray.SetValue(7, 4);

            // Do the required sort first
            Array.Sort(myIntArray);

            return (int[])myIntArray;
        }
    }
}
