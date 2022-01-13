using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220113
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(5);
            hs.Add(10);

            hs.Add(5);//重复不打印
            //bool.hs.Add(5);
            //foreach (int el in hs)
            //    Console.WriteLine(el);

            //Console.WriteLine($"长度是：{hs.Count}");

            //hs.Remove(10);
            Console.WriteLine(hs.Contains(10));//返回bool
            //Console.WriteLine($"现在长度是：{hs.Count}");

            HashSet<string> stringSet = new HashSet<string>() { "Hello", "World", "World" };
            //Console.WriteLine(stringSet.Count);//相同的不显示，自动屏蔽

            //练习-1
            //input{ 1,5,8,9,0,2}
            //output:true

            //input{ 2,2,6}
            //output:false
            //int[] intNum = new int[] { 1, 5, 8, 9, 0, 2 };
            //HashSet<int> stringSet1 = new HashSet<int>() ;
            //Array.Sort(intNum);
            //foreach(int el in intNum)//验证排序成功
            //    Console.WriteLine(el);

            //练习-2

            //List<int> list = new List<int>() { 4, 3, 2, 4, 5, 6, 2, 4, 4 };
            //HashSet<int> temp2 = GetOnlyOneNum(list);
            //foreach(int el in temp2)
            //    Console.WriteLine(el);

            //查找最大元素O(n)
            int[] intNum=new int[] { 4, 3, 2, 4, 5, 6, 2, 4, 4 };
            int temp = 0;
            for (int i = 0; i < intNum.Length-1; i++)//O(n)
            {
                if (intNum[i] > intNum[i + 1])//O(1)
                {
                    temp = intNum[i];
                }
            }
            Console.WriteLine(temp);
        }

        //练习-1
        //static bool Is(HashSet<int> stringSet1)
        //{

        //}

        //练习-2
        static HashSet<int> GetOnlyOneNum(List<int> list)
        {
            list.Sort();
            HashSet<int> hs = new HashSet<int>();
            for(int i = 0; i < list.Count; i++)
            {
                if (!(list[i] == list[i + 1]))
                {
                    hs.Add(list[i]);
                }
            }
            return hs;
        }
    }
}
