using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeProblems.Easy
{
    /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    You can return the answer in any order.

    Example 1:

    Input: nums = [2, 7, 11, 15], target = 9
    Output: [0, 1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    Example 2:

    Input: nums = [3, 2, 4], target = 6
    Output: [1, 2]
    Example 3:

    Input: nums = [3, 3], target = 6
    Output: [0, 1]

    Constraints:

    2 <= nums.length <= 104
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.

    Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?*/


    //TestCase1 : num = [2,7,11,15], target = 9
    //TestCase2 : num = [3,3], target = 6
    //TestCase3 : num = [3,2,4], target = 6

    internal class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            int[] numArr = nums;
            int[] resArr = new int[2];

            for (int i = 0; i < numArr.Length; i++)
            {
                int chkNumOne = numArr[i];

                for (int j = 1; j < numArr.Length; j++)
                {
                    int chkNumTwo = numArr[j];

                    if (chkNumOne + chkNumTwo == target)
                    {
                        resArr[0] = chkNumOne;
                        resArr[1] = chkNumTwo;

                    }
                }
            }
            return resArr;
        }
    }
}
