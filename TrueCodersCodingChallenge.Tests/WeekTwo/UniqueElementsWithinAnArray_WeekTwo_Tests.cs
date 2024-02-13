using TrueCodersCodingChallenge.Console.WeekTwo;

namespace TrueCodersCodingChallenge.Tests
{
    [TestClass]
    public class UniqueElementsWithinAnArray_WeekTwo_Tests
    {
        [TestMethod]
        public void UniqueElementsWithinAnArray_ReturnsNewArrayWithDistinctValues_Success()
        {
            UniqueElementsWithinAnArrayTestHelper<int>([1, 2, 2, 3], [1, 3]);
            UniqueElementsWithinAnArrayTestHelper<string>(["apple", "banana", "apple", "orange"], ["banana", "orange"]);
            UniqueElementsWithinAnArrayTestHelper<double>([1.1, 2.2, 1.1, 3.3], [2.2, 3.3]);
            UniqueElementsWithinAnArrayTestHelper<int>([-1, -1, 2, 3, 3, 3, 4, 5, 5], [ 2, 4]);
            UniqueElementsWithinAnArrayTestHelper<bool>([true, false, true, false, true], []);
            UniqueElementsWithinAnArrayTestHelper<float>([1.1f, 1.10f, 2.2f, 2.20f, 3.3f], [3.3f]);
        }

        public void UniqueElementsWithinAnArrayTestHelper<TArray>(TArray[] input, TArray[] expected)
        {
            var unique = UniqueElementsWithinAnArray_WeekTwo.UniqueElementsWithinAnArray(input);

            Assert.IsNotNull(unique);
            Assert.AreEqual(unique.Length, expected.Length);
            Assert.AreNotEqual(unique.Length, input.Length);
        }

        [TestMethod]
        public void UniqueElementsWithinAnArray_NoUniqueElements_ReturnsArrayWithSameValues_Success()
        {
            UniqueElementsWithinAnArray_NoUniqueElementsTestHelper<int>([1, 2, 3], [1, 2, 3]);
            UniqueElementsWithinAnArray_NoUniqueElementsTestHelper<string>(["apple", "banana", "orange"], ["apple", "banana", "orange"]);
            UniqueElementsWithinAnArray_NoUniqueElementsTestHelper<double>([1.1, 2.2, 3.3], [1.1, 2.2, 3.3]);
            UniqueElementsWithinAnArray_NoUniqueElementsTestHelper<int>([-1, 2, 3, 4, 5], [-1, 2, 3, 4, 5]);
            UniqueElementsWithinAnArray_NoUniqueElementsTestHelper<bool>([true, false,], [true, false]);
            UniqueElementsWithinAnArray_NoUniqueElementsTestHelper<float>([1.1f, 2.2f, 3.3f], [1.1f, 2.2f, 3.3f]);
        }

        public void UniqueElementsWithinAnArray_NoUniqueElementsTestHelper<TArray>(TArray[] input, TArray[] expected)
        {
            var unique = UniqueElementsWithinAnArray_WeekTwo.UniqueElementsWithinAnArray(input);

            Assert.IsNotNull(unique);
            Assert.AreEqual(unique.Length, expected.Length);
            Assert.AreEqual(unique.Length, input.Length);
        }


        [TestMethod]
        public void UniqueElementsWithinAnArray_ArrayIsNull_ReturnsNull_Success()
        {
            var unique = UniqueElementsWithinAnArray_WeekTwo.UniqueElementsWithinAnArray<string>(null);

            Assert.IsNull(unique);
        }

        [TestMethod]
        public void UniqueElementsWithinAnArray_ArrayIsEmpty_ReturnsEmptyArray_Success()
        {
            var unique = UniqueElementsWithinAnArray_WeekTwo.UniqueElementsWithinAnArray<string>([]);

            Assert.IsNotNull(unique);
            Assert.AreEqual(0, unique.Length);
        }
    }
}
