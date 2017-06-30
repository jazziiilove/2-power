/* 
 * Programmer: Baran Topal 
 * Solution name: Number 
 * Project name: Number
 * File name: Program.cs
 * Status: Finished
 */

using System;

namespace Number
{
    /// <summary>
    /// A method that determines whether a number is a 2-power
    /// </summary>
    class Program
    {
        #region methods

        /// <summary>
        /// Function determining whether a number is a 2-power
        /// </summary>
        /// <param name="x">number to check</param>
        /// <returns></returns>
        public static bool DetermineNumber(int x)
        {
            //Binary bisectional search in the array borders (sorted of course)
            int[] powersOfTwo = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824 };
            int interval = 16;
            int exponent = interval; /* Start out at midpoint */

            //during interval limits and the number is not found
            while (x != powersOfTwo[exponent] && interval > 1)
            {
                //if < then, go to left
                if (x < powersOfTwo[exponent])
                    exponent -= interval / 2;
                //if > then, go to right
                else
                    exponent += interval / 2;
                interval /= 2;
            }

            //If found, return true, otherwise false
            if (x == powersOfTwo[exponent])
                return true;
            return false;
        }

        /// <summary>
        /// Main gate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            
            int input = Int32.Parse(Console.ReadLine());
            
            Console.Write("The number, " + input + " is ");            

            if (!DetermineNumber(input))
                Console.Write("not ");
            Console.WriteLine("power of 2");
        }

        #endregion methods
    }
}
