using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    internal class PalindromeNumber
    {
        /*
         Given an integer x, return true if x is a palindrome, and false otherwise.

        Example 1:

        Input: x = 121
        Output: true
        Explanation: 121 reads as 121 from left to right and from right to left.
        Example 2:

        Input: x = -121
        Output: false
        Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        Example 3:

        Input: x = 10
        Output: false
        Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

        Constraints:

        -231 <= x <= 231 - 1

        Follow up: Could you solve it without converting the integer to a string?
         */

        //TestCase 1: 121
        //TestCase 2: -121
        //TestCase 3: 10

        public static bool Solution(int x) 
        {
            int[] intArr = x.ToString().Select(a => int.Parse(a.ToString())).ToArray();

            int[] newArr = new int[intArr.Length];

            int insertIndex = 0;

            for(int i = intArr.Length - 1; i > -1 ; i--)
            {
                newArr[insertIndex] = intArr[i];
                insertIndex++;
            }

            if(intArr.SequenceEqual(newArr))
            {
                return true;
            }

            return false;
        }

        public static bool SolutionTwo(int x)
        {
            if(x < 0)
                return false;

            int num = x;

            int rev = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;

                rev = rev * 10 + lastDigit;

                num = num / 10;
            }

            if(x == rev)
                return true;

            return false;
        }

    }
}
