using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 课后作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //0107-write a function to find the duplicate value inside an array
            //一个函数在数组中查找重复的值
            //input:{2,3,5,2,5,1}
            //output:{2,5}
            //int[] intArray = new int[] { 2, 3, 5, 2, 5, 1 };
            //FindDupvalue(intArray);

            //0111check if two strings contain the same letters but different order
            //0111检查两个字符串是否包含相同的字母但不同的顺序
            //"car","rca":true
            //"hello","hillo":false
            //"java","javal":false
            //"java","javaa":false
            string str1 = "car";
            string str2 = "rca";
            string str3 = "java";
            string str4 = "javal";
            //int a = Convert.ToInt32('a');
            //Console.WriteLine(a);
            //int num = 0;
            //for (int i = 0; i < str1.Length; i++)
            //{
            //    num += Convert.ToInt32(str1[i]);
            //}
            //Console.WriteLine(num);

            FindSameChar(str1, str2);
            FindSameChar(str3, str4);


        }
        //0111检查两个字符串是否包含相同的字母但不同的顺序
        static void FindSameChar(string str1,string str2)
        {
            if(changeToNum(str1)== changeToNum(str2))
                Console.WriteLine($"{str1} {str2}: true");
            else
                Console.WriteLine($"{str1} {str2}: false");

        }

        static int changeToNum(string str)
        {
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                num += Convert.ToInt32(str[i]);
            }
            return num;
        }


        //0107-一个函数在数组中查找重复的值
        static void FindDupvalue(int[] intArray)
        {
            List<int> newArray = new List<int>();
            for(int i=0; i < intArray.Length-1; i++)
            {
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if(intArray[i]== intArray[j])
                    {
                        newArray.Add(intArray[i]);
                        //Console.WriteLine(intArray[i]);
                    }
                }
            }
            foreach(int el in newArray)
                Console.WriteLine(el);
        }
    }
}
