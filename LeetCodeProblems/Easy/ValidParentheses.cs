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
        //TestCase 4: "([])"
        //TestCase 5: "([)]" //false
        //TestCase 6: "(){}}{"
        //TestCase 7: "({{{{}}}))"
        //TestCase 8: "[[[]"

        public static bool Solution(string s)
        {
            if (s == null || s.Length % 2 != 0) return false;

            Stack<char> stackChars = new Stack<char>();

            bool result = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (stackChars.Count == 0 && (s[i] == ')' || s[i] == '}' || s[i] == ']')) return false;

                if(stackChars.Count != 0)
                {
                    if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    {
                        stackChars.Push(s[i]);
                    }
                    else
                    {
                         char stackChar = stackChars.Pop();

                            string cbmprths = stackChar.ToString() + s[i];

                            if (cbmprths == "()")
                            {
                                result = true;
                            }
                            else if (cbmprths == "{}")
                            {
                                result = true;
                            }
                            else if (cbmprths == "[]")
                            {
                                result = true;
                            }
                            else
                            {
                                 return false;
                            }
                    }
                }
                else if(stackChars.Count == 0)
                {
                     stackChars.Push(s[i]);
                }


            }

            if(stackChars.Count > 0)
            {
                return false;
            }
            return result;
        }
    }
}
