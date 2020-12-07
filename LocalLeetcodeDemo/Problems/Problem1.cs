using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LocalLeetcodeDemo
{
    public class Problem1 : IProblem
    {
        public void Start()
        {
            int[] resources = new int[] { 2, 7, 11, 15 };
            var res = TwoSum(resources, 9);
        }

        /// <summary>
        /// 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
        /// 你可以假设每种输入只会对应一个答案。但是，数组中同一个元素不能使用两遍。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            bool flag = false;
            int[] Res = new int[2];
            Dictionary<int,int> dict = new Dictionary<int, int>();
            int numsLength = nums.Length;
            for (int i = 0; i < numsLength; i++)
            {
                if(dict.TryGetValue(nums[i], out int value))
                {
                    Res[0] = i;
                    Res[1] = dict[nums[i]];
                    break;
                }
                dict.TryAdd(target - nums[i], i);
            }
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (target == nums[i] + nums[j])
            //        {
            //            Res[0] = i;
            //            Res[1] = j;
            //            flag = true;
            //            break;
            //        }
            //    }
            //    if (flag)
            //    {
            //        break;
            //    }
            //}
            return Res;
        }
    }
}
