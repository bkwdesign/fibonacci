using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bkwdesign.math
{
    /// <summary>
    /// A utility class featuring a single static method for discovering the Nth fibonacci number.
    /// Error is thrown if result exceeds a normal Int64's maximum value.
    /// </summary>
    /// <remarks>
    /// Adapted logic from this article
    /// http://www.dotnetperls.com/fibonacci
    /// 
    /// Interally changed it to used unsigned Int64 so we can throw an error.
    /// </remarks>
    public class fibonacci
    {
        /// <summary>
        /// pass in a number representing the Nth fibocanni number you wish to retrieve
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long GetNthNumber(long n)
        {
            ulong a = 0;
            ulong b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (long i = 0; i < n; i++)
            {
                ulong temp = a;
                a = b;
                b = temp + b;
            }
            if (a > Int64.MaxValue)
            {
                throw new InvalidOperationException(String.Format("The {0}th fibonacci exceeds the acceptable range for this application {1}.", n, a));
            }
            return (long)a;
        }
    }
}
