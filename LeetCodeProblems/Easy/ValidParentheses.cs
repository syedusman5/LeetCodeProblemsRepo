using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    internal class ValidParentheses
    {
        /*
         Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        An input string is valid if:

        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Every close bracket has a corresponding open bracket of the same type.
 
        Example 1:
        Input: s = "()"
        Output: true

        Example 2:
        Input: s = "()[]{}"
        Output: true

        Example 3:
        Input: s = "(]"
        Output: false

        Example 4:
        Input: s = "([])"
        Output: true

        Example 5:
        Input: s = "([)]"
        Output: false

        Constraints:
        1 <= s.length <= 104
        s consists of parentheses only '()[]{}'.
         */

        //TestCase 1: "()"
        //TestCase 2: "()[]{}"
        //TestCase 3: "(]"
        //TestCase 3: "([])"
        //TestCase 3: "([)]"

        public static bool Solution(string s)
        {
            char[] strArr = s.ToCharArray();

            for(int i = 0; i < strArr.Length; i++)
            {

            }

            return true;
        }
    }
}
