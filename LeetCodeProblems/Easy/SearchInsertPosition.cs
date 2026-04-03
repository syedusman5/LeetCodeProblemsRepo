using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    internal class SearchInsertPosition
    {
        /*
            Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

            You must write an algorithm with O(log n) runtime complexity.

            Example 1:

            Input: nums = [1,3,5,6], target = 5
            Output: 2
            Example 2:

            Input: nums = [1,3,5,6], target = 2
            Output: 1
            Example 3:

            Input: nums = [1,3,5,6], target = 7
            Output: 4
 

            Constraints:

            1 <= nums.length <= 104
            -104 <= nums[i] <= 104
            nums contains distinct values sorted in ascending order.
            -104 <= target <= 104
         */


        //Test case 1 : [1,3,5,6] 5 
        //Test case 2 : [1,3,5,6] 2
        //Test case 3 : [1,3,5,6] 7

        public static int Solution(int[] nums, int target)
        {
            int res = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == target)
                {
                    return i;
                }
                else if (nums[i] < target)
                {
                    if (nums.Length - 1 == i)
                    {
                        return i + 1;
                    }
                    else if (nums.Length - 1 < i)
                    {
                        return i;
                    }
                }
                else if (nums[i] > target)
                {
                    if (nums.Length - 1 < i)
                    {
                        return res = i - 1;
                    }

                    return i;
                }

            }

            return res;
        }
    }
}
