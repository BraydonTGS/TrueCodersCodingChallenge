namespace TrueCodersCodingChallenge.Console.WeekOne
{
    /// <summary>
    /// Write a function to calculate the factorial of a given number.
    /// 
    /// The factorial of a non-negative integer n is the product of all positive integers less than or equal to n.
    /// 
    /// </summary>
    public static class DetermineFactorial_WeekOne
    {
        #region DetermineFactorial
        /// <summary>
        /// Determine the Factorial of a Number using Recursion.
        /// 
        /// Zero will always return 1
        /// 
        /// If the Value is less than zero, throw an ArgumentException as the Factorial is not Defined. 
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int DetermineFactorial(int num)
        {
            if (num < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");

            if (num == 0)
                return 1;

            return num * DetermineFactorial(num - 1);
        }

        #endregion

    }
}
