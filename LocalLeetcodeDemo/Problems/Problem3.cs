using System;

namespace LocalLeetcodeDemo
{
    /// <summary>
    /// 无重复字符的最大子串
    /// </summary>
    public class Problem3 : IProblem
    {
        public void Start()
        {
            // 准备数据
            string Test1 = "abcabcbb";
            Console.WriteLine(LengthOfLongestSubstring(Test1));
        }

        public int LengthOfLongestSubstring(string s)
        {
            // 滑动窗口
            int WindowLeft = 0;
            int WindowRight = 0;
            // int WindowRight = 0;
            // 当前最长的窗口长度，窗口每变化一次，就重新计算一次长度。
            // 窗口内字符的最后出现位置的字典
            // System.Collections.Generic.Dictionary<char, int> Locations = new System.Collections.Generic.Dictionary<char, int>();
            int[] Locations = new int[256];
            // 初始化值为-1，表明没有赋值过位置
            for (int i = 0; i < 256; i++)
            {
                Locations[i] = -1;
            }

            // 最长长度
            int MaxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                WindowRight = i;
                var c = s[i];
                if (Locations[(int)s[i]] == -1)
                {
                    // 还没有遇到,记录位置
                    Locations[(int)s[i]] = i;
                }
                else
                {
                    // 判断是否在窗口内
                    if (Locations[(int)s[i]] >= WindowLeft)
                    {
                        // 窗口左边界移动到后一位
                        WindowLeft = Locations[(int)s[i]] + 1;
                    }

                    Locations[(int)s[i]] = i;
                }

                // 重新计算长度
                int Length = WindowRight - WindowLeft + 1;
                Console.WriteLine(string.Format("current length:{0}", Length));
                if (Length > MaxLength)
                {
                    MaxLength = Length;
                }

                Console.WriteLine(string.Format("current length:{0}, max length:{1}", Length, MaxLength));
            }

            return MaxLength;
        }
    }
}