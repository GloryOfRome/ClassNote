using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220119
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of integers, write a function that returns true, if and only if, the number of occurrences of each value in the array is unique.
             * 给定一个整数数组，编写一个函数，当且仅当数组中每个值出现的次数是唯一的，该函数返回 true。
             Example 1:
               Input: arr = [1,2,2,1,1,3]
               Output: true
             * **/
            int[] arr = new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            Console.WriteLine($"数据频率：{DifferentFrequency(arr)}");

            /*
             * Given a non-negative integer num, return the number of steps to reduce it to zero. If the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
             * 给定一个非负整数 num，返回将其减少为零的步数。如果当前数字是偶数，则必须将其除以 2，否则，必须从中减去 1。
             *Input: num = 14
                Output: 6
                Explanation: 
                Step 1) 14 is even; divide by 2 and obtain 7. 
                Step 2) 7 is odd; subtract 1 and obtain 6.
                Step 3) 6 is even; divide by 2 and obtain 3. 
                Step 4) 3 is odd; subtract 1 and obtain 2. 
                Step 5) 2 is even; divide by 2 and obtain 1. 
                Step 6) 1 is odd; subtract 1 and obtain 0.
             * **/
            NumberOfSteps(123);
            Console.WriteLine();

            /*
             Given an integer n, return any array containing n unique integers such that they add up to 0.
             给定一个整数 n，返回任何包含 n 个唯一整数且它们加起来为 0 的数组。
             * **/
            Console.WriteLine("验证是都可以得到随机数");
            int num3 = 1;
            Random ran = new Random();
            int num1 = ran.Next(0,2*num3);
            int num2 = -num1;
            Console.WriteLine($"随机数是{num1}和{num2}");
            Console.WriteLine("Question 3");
            ThroughNumberGetArray(num3);
        }
        //Question 3:
        /*
         Input: n = 5
           Output: [-7,-1,1,3,4]
           Explanation: These arrays also are accepted [-5,-1,1,2,3] , [-3,-1,2,-2,4].
         * **/

        static void ThroughNumberGetArray(int num)
        {
            /*
             * 判断给的数字奇偶性
             * 如果是奇数，数组为0和随机num/2次的随机数，此处随机数不相等
             * 可以用hashset去重，当count等于数字时，随机数停止
             * 将hashset放入int[]，同时排序
             * **/
            HashSet<int> hs = new HashSet<int>();
            Random ran = new Random();
            if (num % 2 == 0)
            {
                while (hs.Count != num)
                {
                    int temp = ran.Next(0, 2 * num);
                    hs.Add(temp);
                    hs.Add(-temp);
                }
            }

            if (num % 2 != 0)
            {
                while (hs.Count != num)
                {
                    int temp = ran.Next(0, 2 * num);
                    hs.Add(0);
                    hs.Add(temp);
                    hs.Add(-temp);
                }
            }

            Console.WriteLine("查看hs中的元素");
            foreach(int el in hs)
                Console.WriteLine(el);

            Console.WriteLine("新建一个数组放入hashset的值");
            int[] result = new int[num];
            int index = 0;
            foreach(int el in hs)
            {
                result[index++] = el;
            }
            Array.Sort(result);
            foreach(int el in result)
                Console.WriteLine(el);

        }

        //Question 2:
        static void NumberOfSteps(int num)
        {
            /*
             * 判断num是否是非负数
             * 判断num是奇数还是偶数，建立辅助函数
             * 如果是奇数先减一，然后被2除，每一步需要一个计数器
             * 如果是偶数直接被2除
             * 当结果为0时，结束，并返回计数器数字
             * **/
            Console.WriteLine("Question 2:");
            Console.WriteLine("判断num是否是非负数");
            if (num < 0)
                return;
            Console.WriteLine($"{num}是非负数");
            int counter = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    counter++;
                }
                if (num % 2 != 0)
                {
                    num = num -1;
                    counter++;
                }
            }
            Console.WriteLine($"需要{counter}完成");

        }


        //Question 1:
        static bool DifferentFrequency(int[] arr)
        {
            /*
             * X将array排序
             * X把array放入hashset，取消重复值
             * X将value放入dictiona，做key
             * X判断array中的值是否包含在dictinary中每个key，是的话，value加一
             * X计算数组中，数字出现的频率
             * 判断每一个dict.value不相同--利用他们长度的对比
             * **/
            Array.Sort(arr);
            HashSet<int> hs = new HashSet<int>(arr);
            HashSet<int> hs1 = new HashSet<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(int el in hs)
                dict.Add(el,0);
            Console.WriteLine("检查dict看看里面的值");
            foreach (var el in dict)
                Console.WriteLine(el);
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                    dict[arr[i]]++;
            }
            foreach (KeyValuePair<int, int> el in dict)//达到将key放入value为0的目的
                Console.WriteLine($"key: {el.Key},value: {el.Value}");
            Console.WriteLine("第一次遍历hs1看看里面的值");
            foreach (int el in hs1)
                Console.WriteLine(el);
            Console.WriteLine("把dict中的value放入hs1中，遍历");
            foreach (var el in dict)
            {
                hs1.Add(el.Value);
                Console.WriteLine(el.Value);
            }
            Console.WriteLine("检查hs1中的值是不是数字出现的频率，遍历");

            foreach (int el in hs1)
                Console.WriteLine(el);
            Console.WriteLine("判断两个hashset的长度是否一样");
            if (hs.Count == hs1.Count)
                return true;
            return false;


        }
    }
}
