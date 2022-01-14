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
            //Console.WriteLine(hs.Contains(10));//返回bool
            //Console.WriteLine($"现在长度是：{hs.Count}");

            HashSet<string> stringSet = new HashSet<string>() { "Hello", "World", "World" };
            //Console.WriteLine(stringSet.Count);//相同的不显示，自动屏蔽

            //练习-1
            //input{ 1,5,8,9,0,2}
            //output:true

            //input{ 2,2,6}
            //output:false

            
            Console.WriteLine("EX1");
            List<int> list1 = new List<int>() { 1, 5, 8, 9, 0, 2 };
            List<int> list2 = new List<int>() { 2, 2, 6 };
            list1.Sort();//方法一
            //Array.Sort(intNum);//方法二
            bool b1 = CheckForDuplication(list1);
            bool b2 = CheckForDuplication(list2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);



            //练习-2

            //List<int> list2 = new List<int>() { 4, 3, 2, 4, 5, 6, 2, 4, 4 };
            //HashSet<int> temp2 = GetOnlyOneNum(list);
            //foreach(int el in temp2)
            //    Console.WriteLine(el);

            ////查找最大元素O(n)
            //int[] intNum=new int[] { 4, 3, 2, 4, 5, 6, 2, 4, 4 };
            //int temp = 0;
            //for (int i = 0; i < intNum.Length-1; i++)//O(n)
            //{
            //    if (intNum[i] > intNum[i + 1])//O(1)
            //    {
            //        temp = intNum[i];
            //    }
            //}
            //Console.WriteLine(temp);

            //练习-3
            //List<int> list3 = new List<int>() { 1, 5, 7, 10, 1, 7, 1, 9 };
            //list3.Sort();
            ////HashSet<int> hs3 = new HashSet<int>(list3);
            //int[] num3 = new int[10];
            //for(int i = 0; i < list3.Count; i++)
            //{
            //    int temp = list3[i]-1;
            //    num3[temp]++;
            //}
            //foreach(int el in num3)
            //    Console.WriteLine(el);

            string str = "aabcggjabbbc";
            GetMostShow(str);
        }

        static void GetMostShow(string str)
        {
            string[] temp = new string[26];

            //1-转ASK码
            //int aa = Convert.ToInt32('a');
            //int a = Convert.ToInt32('z');
            //Console.WriteLine(aa);
            //Console.WriteLine(a);

            for (int i = 0; i < str.Length; i++)
            {
               
            }

        }
        //练习-2
        static HashSet<int> GetOnlyOneNum(List<int> list)
        {
            list.Sort();
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!(list[i] == list[i + 1]))
                {
                    hs.Add(list[i]);
                }
            }
            return hs;
        }

        //练习-1
        /*
         * check if a list has all unique elements using a HashSet
         * example:
         * input:{1,5,8,9,0,2}
         * output:true
         * 
         * input:{2,2,6}
         * output:false
         * 
         * what if the list is very big and we want to exit with a result as soon as possible?
         * 如果列表很大并且我们想尽快退出并得到结果怎么办？
         * **/
        static bool CheckForDuplication(List<int> list1)
        {
            //方法一
            HashSet<int> hs1 = new HashSet<int>(list1);//将list1装入hs1
            if (hs1.Count == list1.Count)
                return true;
            return false;


            ////方法二--更好的方法
            //HashSet<int> hs1 = new HashSet<int>();
            ////foreach(int el in list1)
            ////    Console.WriteLine(el);//验证排序成功
            //for (int i = 0; i < list1.Count; i++)
            //{
            //    if (!hs1.Add(list1[i]))
            //        return false;
            //}
            //    return true;
        }
    }
}
