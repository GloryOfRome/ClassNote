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

            //string[] arr3 = new string[] { "Hello", "World", "I", "am", "Learning", "C#" };
            //List<string> arrNum3 = new List<string>();
            //arrNum3.AddRange(arr3);

            //List<string> temp = FindUniqueNumbers(arrNum3);
            //foreach(string item in temp)
            //    Console.WriteLine(item);

            //练习-4-下午
            //write a method to print a list of lists of integers
            //编写一个方法来打印一个由整数组成的列表
            //before each sub-list's contents, print its size
            //在每个子列表的内容之前，打印其大小

            //List<int> n1 = new List<int> { 1, 2, 3 };
            //List<int> n2 = new List<int> { 4, 5,6,7 };
            //List<int> n3 = new List<int> { 8, 9 };
            //List<List<int>> listOfLists = new List<List<int>>() { n1, n2, n3 };
            //PrintListOfList(listOfLists);


            //练习-5
            //we have two sorted int lists
            //and we want to merge them in a new sorted list
            //input list1 = { 1, 5, 8, 9 }  list2 = { 1, 2, 3, 10 }
            //output result = { 1,1,2,3, 5, 8, 9 ,10}

            /*
             *-repeat the question with arrays用数组重复问题
             *-iterate over both lists (while both lists still have items)
             * 遍历两个列表（虽然两个列表仍然有项目）
             *  -compare an item from list and list2
             *  比较 list 和 list2 中的项目
             *  -place the smaller item in the result
             *  将较小的项目放在结果中
             *  -increase the counter of the smaller item's array
             *  增加较小项目数组的计数器
             *  -if the two numbers are equal, place both, and increase both counts
             *  如果两个数字相等，放置两个，并增加两个计数
             *  
             * -check to see if there are any remaining items in either lists
             * 检查任一列表中是否还有剩余项目
             * -place any remainng items in the result
             * 在结果中放置任何剩余的项目
             * **/

            List<int> list1 = new List<int> { 1, 5, 8, 9 };
            List<int> list2 = new List<int> { 1, 2, 3, 10 };
            List<List<int>> newListOfLists = new List<List<int>>() { list1, list2 };
            while ()
            {

            }
            for(int i = 0; i < list1.Count-1; i++)
            {
                for (int j = i+1; j < list2.Count; j++)
                {
                    if(list1[i]<list2[j])
                }
            }



        }
        //练习-5
        static List<int> GetOneList(List<int> list1,List<int> list2)
        {
            List<int> resule = new List<int>();
            int i = 0;
            int j = 0;

            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i] < list2[j])
                {
                    resule.Add(list1[i]);
                }
            }
        }

        static void PrintListOfList(List<List<int>> listOfLists)
        {
            foreach(List<int> el in listOfLists)
            {
                Console.WriteLine($"the length is {el.Count}");
                foreach (int item in el)
                    Console.WriteLine(item);
            }
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
