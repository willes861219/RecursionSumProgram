using System;

namespace RecursionSum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("請輸入最大值");
            var InputNum = Console.ReadLine();
            int MaxNum; //宣告一個整數值，放置轉換後的值

            bool success = Int32.TryParse(InputNum, out MaxNum);
            if (success)
            {
                Console.WriteLine("加總為：" + RecursionSum(MaxNum));
            }
            else
            {
                Console.WriteLine($"沒辦法轉換'{InputNum}'成整數值");
            }

            Console.ReadKey();
        }

        //遞迴-算出最大數字加總，例如：1+2+3+4+5 = 15
        static int RecursionSum(int MaxNum)
        {
            if (0 >= MaxNum)
            {
                return 0;
            }
            else
            {
                return MaxNum + RecursionSum(MaxNum - 1);
            }
        }
    }
}
