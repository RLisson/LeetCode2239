using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2239
{
    internal class Solution
    {
        public static int FindClosestNumber(params int[] nums)
        {
            int closest = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) < Math.Abs(closest))
                {
                    closest = nums[i];
                }
            }
            if (closest < 0 && nums.Contains(Math.Abs(closest)))
            {
                return Math.Abs(closest);
            }
            return closest;
        }
    }
}
