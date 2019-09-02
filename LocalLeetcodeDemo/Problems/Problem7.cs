using System;

namespace LocalLeetcodeDemo
{
    /// <summary>
    /// 整数反转
    /// </summary>
    public class Problem7 : IProblem
    {
        public void Start()
        {
            int Test = 10;
            int Res = Reverse(Test);
            Console.WriteLine(string.Format("Origin:{0}, After Convert:{1}", Test, Res));
        }

        public int Reverse(int x)
        {
            // 转成字符数组
            var Chars = x.ToString().ToCharArray();
            int Length = Chars.Length;
            int StartIndex = 0;
            if (Chars[0] == '-')
            {
                StartIndex = 1;
            }

            int Count = Length - StartIndex;

            for (int i = 0; i < Count / 2; i++)
            {
                char temp = Chars[StartIndex + i];
                Chars[StartIndex + i] = Chars[StartIndex + Count - 1 - i];
                Chars[StartIndex + Count - 1 - i] = temp;
            }

            string ResString = new string(Chars);
            Int64 Res = Int64.Parse(ResString);
            if(Res > Int32.MaxValue || Res < Int32.MinValue)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(Res);
            }
        }
    }
}