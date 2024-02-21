namespace TrueCodersCodingChallenge.Console.WeekThree
{
    /// <summary>
    ///  Notes on the Return Index: 
    ///  The index of the specified value in the specified array, if value is found; otherwise, a negative number. 
    ///  If value is not found and value is less than one or more elements in array, 
    ///  the negative number returned is the bitwise complement of the index of the first element that
    ///  is larger than value. If value is not found and value is greater than all elements in array, the negative number returned is the bitwise complement of (the index of the
    ///  last element plus 1). 
    ///  If this method is called with a non-sorted array, the return value can be incorrect and a negative number could be returned, even if value is present in array.
    /// </summary>
    public static class BinarySearchSortedArray_WeekThree
    {

        #region BinarySearchOnASortedArray
        /// <summary>
        /// Generic Binary Search On A Sorted Array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="searchParams"></param>
        /// <returns></returns>
        public static int? BinarySearchOnASortedArray<T>(
            Array array, T searchParams) =>
            Array.BinarySearch(array, searchParams);
        #endregion

        #region BinarySearchImplementation
        /// <summary>
        /// Performs a binary search on a sorted array.
        /// </summary>
        public static int BinarySearchImplementation<T>(T[] array, T search) where T : IComparable<T>
        {
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var median = (left + right) / 2;
                var item = array[median];

                var comparison = search.CompareTo(item);
                if (comparison == 0)
                    return median;

                if (comparison < 0)
                    right = median - 1;

                else
                    left = median + 1;
            }

            return -1;
        }
        #endregion

    }
}
