﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220112
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试打印数组，数组不可以打印，但是分割符连接后，以数组形式显示
            //string[] str = new string[] { "werew", "dscxv", "23" };
            //Console.WriteLine(str);
            //Console.WriteLine(string.Join(" ",str));
            //Console.WriteLine(string.Join("--",str));

            int[] arr = new int[] { 1, 3, 5, 6 };
            string[] arrStr = new string[] { "saas", "asdas", "asfas" };
            char[] arrCha = new char[] { 's', 'f', 'g' };
            //1--list<T>T是所有的type
            List<int> num = new List<int>();
            List<string> words = new List<string>();
            List<char> letter = new List<char>();

            //2--添加
            num.Add(16);
            num.Add(16);
            num.Add(19);
            words.Add("nihao");

            ////3--长度
            //Console.WriteLine(num.Count);

            ////4--cotains
            //Console.WriteLine(num.Contains(16));

            ////5--打印
            //Console.WriteLine(num[0]);

            ////6-赋值,更改
            //num[1] = 18;
            //Console.WriteLine(num[1]);

            //7-删除 bool 只删除第一个 remove、remeoveall,removeat
            //num.Remove(16);
            ////num.RemoveAll(x=16);//错误
            //Console.WriteLine(num.Count);
            //num.RemoveAll(x => x % 2 == 1);
            //Console.WriteLine(num.Count);
            //Console.WriteLine(num.Contains(16));
            //num.Remove(116);
            //Console.WriteLine(num.Contains(116));
            //num.RemoveAt(1);//删除指定索引

            ////8--addrange数组转成list
            num.AddRange(arr);
            words.AddRange(arrStr);
            letter.AddRange(arrCha);
            //Console.WriteLine(num.Count);
            //Console.WriteLine(num);
            //PrintList(num);
            //PrintList(words);

            //练习-1
            int[] arr1 = new int[] { 1, 5, 7, 3, 1, 7, 9 };
            List<int> arrNum1 = new List<int>();
            //arrNum1.AddRange(arr1);
            //NewList(arrNum1);

            //练习-2
            //input:{"Hello","World","I","am","Learning","C#"}
            //output:{"I","am","C#"}
            //string[] arr2 = new string[] { "Hello", "World", "I", "am", "Learning", "C#" };
            //List<string> arrNum2 = new List<string>();
            //arrNum2.AddRange(arr2);

            //foreach(string el in arrNum2)
            //{
            //    if (el.Length < 3)
            //    {

            //    }
            //}


            //练习-3
            string[] arr3 = new string[] { "Hello", "World", "I", "am", "Learning", "C#" };
            List<string> arrNum3 = new List<string>();
            arrNum3.AddRange(arr3);
            foreach(string el in GetOldArr(arrNum3))
                Console.WriteLine(el);

        }
        static List<string> GetOldArr(List<string> arrNum3)
        {
            foreach (string el in arrNum3)
            {
                if (el.Length > 3)
                    arrNum3.Remove(el);
            }
            return arrNum3;
        }

        static void  NewList(List<int> arrNum)
        {
            for (int i = 0; i < arrNum.Count - 1; i++)
            {
                for (int j = i + 1; j < arrNum.Count; j++)
                {
                    if (arrNum[i] == arrNum[j])
                        arrNum.RemoveAt(j);
                }
            }
            foreach (int el in arrNum)
                Console.WriteLine(el);
        }

        static void PrintList(List<int> list)
        {
            foreach(int el in list)
                Console.WriteLine(el);
        }

        static void PrintList(List<string> list)
        {
            foreach (string el in list)
                Console.WriteLine(el);
        }

        static void PrintList(List<char> list)
        {
            foreach (char el in list)
                Console.WriteLine(el);
        }
    }
}
