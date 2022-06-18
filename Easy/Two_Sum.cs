using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Easy
{
    internal class Two_Sum
    {
        //testcases
        //[2,7,11,15]
        //9
        //[3,2,4]
        //6
        //[3,3]
        //6

        public int[] TwoSum(int[] nums, int target)
        {
            for (int num1 = 0; num1 < nums.Count(); num1++)
            {
                for (int num2 = 0; num2 < nums.Count(); num2++)
                {
                    if (num1 == num2)
                        continue;

                    if (nums[num1] + nums[num2] == target)
                        return new int[] { num1, num2 };
                }
            }
            return null;
        }
    }
    
}
