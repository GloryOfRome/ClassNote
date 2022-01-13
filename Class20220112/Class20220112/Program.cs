using System;
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
            //num.RemoveAll(x => x == 16);
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

            //9--list用foreach循环不能修改内部值
            //Console.WriteLine("9---");
            //int index = 0;
            //foreach(int el in num)
            //{
            //    Console.WriteLine(el);
            //    el = index;//红线

            //}

            //练习-1
            /*
             * Cereat a new list from an original list with only the unique values
             * input{ 1, 5, 7, 3, 1, 7, 9 };
             * output{ 1, 5, 7, 3, 9 };
             * **/

            //Console.WriteLine("我同学写的");
            //int[] numbersArr = new int[] { 1, 5, 7, 3, 1, 7, 9 };
            //List<int> uniqueNumbers = FindUniqueNumbers(numbersArr);
            //foreach (int number in uniqueNumbers)
            //{
            //    Console.WriteLine("The unique number is:" + number);
            //}

            //Console.WriteLine("我写的");
            //int[] arr1 = new int[] { 1, 5, 7, 3, 1, 7, 9 };
            //List<int> list = new List<int>();
            //list.AddRange(arr1);
            //List<int> temp = GetUniqueList(list);
            //foreach (int item in temp)
            //    Console.WriteLine(item);

            //练习-2长度小于3的打印出来
            //creat a new list from an original string list
            //where you only keep the words less than 3 letters
            //input:{"Hello","World","I","am","Learning","C#"}
            //output:{"I","am","C#"}

            //string[] arr2 = new string[] { "Hello", "World", "I", "am", "Learning", "C#" };
            //List<string> arrNum2 = new List<string>();
            //arrNum2.AddRange(arr2);

            //List<string> temp2 = GetOldArr(arrNum2);
            //foreach (string el in temp2)
            //{
            //    Console.WriteLine(el);
            //}


            //练习-3
            //repeat the previous question同练习2，但是修改的是老list
            //but modify the same original list instead of creating a new one

            string[] arr3 = new string[] { "Hello", "World", "I", "am", "Learning", "C#" };
            List<string> arrNum3 = new List<string>();
            arrNum3.AddRange(arr3);

            List<string> temp = FindUniqueNumbers(arrNum3);
            foreach(string item in temp)
                Console.WriteLine(item);

            //练习-4-下午
            //List<int> n1 = new List<int> { 1, 2, 3 };
            //List<int> n2 = new List<int> { 1, 2, 3 };
            //List<int> n3 = new List<int> { 1, 2, 3 };
            //List<List<int>> listOfLists = new List<List<int>>() { n1, n2, n3 };

            //foreach(List<int> el in listOfLists)
            //{
            //    foreach(int item in el)
            //        Console.WriteLine(item);
            //}

            //练习-5
            List<int> list1 = new List<int> { 1, 5, 8, 9 };
            List<int> list2 = new List<int> { 1, 2, 3, 10 };
            List<List<int>> newListOfLists = new List<List<int>>() { list1, list2 };
            //int[] number = new int[list1.Count+list2.Count];
            //for(int i=0;i< newListOfLists.Count-1; i++)
            //{
            //    int temp = 0;
            //    for (int i = i+1; i < newListOfLists.Count; i++)
            //        if(newListOfLists)
            //}



        }

        //练习-3
        static List<string> FindUniqueNumbers(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > 3)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
            return list;
        }

        //练习-2
        static List<string> GetOldArr(List<string> arrNum3)
        {
            List<string> shortWordList = new List<string>();
            foreach(string word in arrNum3)
            {
                if (word.Length < 3)
                    shortWordList.Add(word);
            }
            return shortWordList;
        }

        //练习-1
        static List<int>  GetUniqueList(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (int item in list)
            {
                if (!result.Contains(item))
                    result.Add(item);
            }
            return result;
        }


        //polymorphism多态-int
        static void PrintList(List<int> list)
        {
            foreach(int el in list)
                Console.WriteLine(el);
        }

        //polymorphism多态-string
        static void PrintList(List<string> list)
        {
            foreach (string el in list)
                Console.WriteLine(el);
        }

        //polymorphism多态-char
        static void PrintList(List<char> list)
        {
            foreach (char el in list)
                Console.WriteLine(el);
        }
    }
}
