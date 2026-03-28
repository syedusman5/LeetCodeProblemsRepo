using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    internal class LongestCommonPrefix
    {
        /*
        Write a function to find the longest common prefix string amongst an array of strings.

        If there is no common prefix, return an empty string "".

        Example 1:

        Input: strs = ["flower","flow","flight"]
        Output: "fl"
        Example 2:

        Input: strs = ["dog","racecar","car"]
        Output: ""
        Explanation: There is no common prefix among the input strings.
 

        Constraints:

        1 <= strs.length <= 200
        0 <= strs[i].length <= 200
        strs[i] consists of only lowercase English letters if it is non-empty.
         */

        //TestCase 1 : ["flower","flow","flight"]
        //TestCase 2 : ["dog","racecar","car"]

        public static string Solution(string[] strs)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 1; i++) 
            {
                char[] indivString = strs[i].ToCharArray(); 

                for (int j = 0; j < indivString.Length; j++)
                {
                    char chkChar = indivString[j];

                    for(int k = 0; k < strs.Length; k++) 
                    {
                        char[] chkCharString = strs[k].ToCharArray();

                        if(chkChar == chkCharString[k])
                        {
                            sb.Append(chkChar);
                        }
                    }
                }

            }

            if( sb.Length > 1 )
            {
                return sb.ToString();
            }

            return "";
        }
    }
}
