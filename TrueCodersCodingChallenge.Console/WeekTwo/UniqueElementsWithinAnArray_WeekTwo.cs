using System.Linq;
namespace TrueCodersCodingChallenge.Console.WeekTwo
{
    /// <summary>
    /// Implement a function that takes an array as input and returns a new array containing only the unique elements of the original array.
    /// 
    /// Ensure that the order of elements is preserved
    /// 
    /// </summary>
    public static class UniqueElementsWithinAnArray_WeekTwo
    {
        /// <summary>
        /// Generic Method Used to Return a New Array with only Unique (Distinct) values.
        /// 
        /// GroupBy to group elements by their value
        /// 
        /// Where filter the groups where the count is 1
        /// 
        /// Select the Key of each group - Key - Unique Element
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T[]? UniqueElementsWithinAnArray<T>(T[] array)=> 
            array is null || array.Length is 0 ? array : array
            .GroupBy(x => x)
            .Where(x => x.Count() == 1)
            .Select(x => x.Key)
            .ToArray();
    }
}