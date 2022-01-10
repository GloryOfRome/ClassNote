using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220110
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1--有一组重复数字的数组
            //int[] intArray1 = new int[] { 1, 3, 1, 4, 5, 5, 6 };
            //FindTwoNumber(intArray1);

            ////2--有多组重复数字的数组
            //Console.WriteLine("-------------------");
            //int[] intArray2 = new int[] { 1, 1, 3, 1, 4, 5, 5, 6 };
            //int[] temporaryNumArray = BubbleSort(intArray2);
            //everyEleArray(temporaryNumArray);

            //Console.WriteLine("-------------------");
            //FindOverTwoNumber(intArray2);

            string[] stringArray = new string[] { "friend", "best", "bet" };

            ////3-验证string[]中个别元素
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    for (int j = 0; j < stringArray[i].Length; j++)
            //    {
            //        Console.WriteLine(stringArray[i][j]);
            //    }

            //}

            ////4-string[]中元素连到一起
            //string aa = "";

            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    aa = aa + stringArray[0];
            //}
            //Console.WriteLine(aa);





            ////有问题
            //Console.WriteLine("-------------------");
            ////把array装入list数组
            //List<int> li = new List<int>();
            //for (int i = 0; i < temporaryNumArray.Length; i++)
            //{
            //    if(temporaryNumArray[i]== temporaryNumArray[i+1])
            //        li.Add(temporaryNumArray[i]);
            //}

                //Console.WriteLine("-------------------");
                ////everyEleArray(li);
                //foreach (var el in li)
                //    Console.WriteLine(el);
        }


        //遍历List
        static void everyEleArray(List<int> newList )
        {
            foreach(var el in newList)
                Console.WriteLine(el);
        }

        //遍历数组
        static void everyEleArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);
        }

        //对数组进行排序
        static int[] BubbleSort(int[] intArray)
        {
            int temporaryNum = 0;
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temporaryNum = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temporaryNum;
                    }
                }
            }
            return intArray;
        }

        //如果重复数字只有两个可以实现
        static void FindTwoNumber(int[] intArray)
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        Console.WriteLine(intArray[i]);
                    }
                }
            }
        }

        //如果重复数字超过两个可以实现
        static void FindOverTwoNumber(int[] intArray)
        {
            if(intArray[0] != intArray[1])
                Console.WriteLine(intArray[0]);
            Console.WriteLine("-------------------");

            for (int i = 1; i < intArray.Length - 1; i++)
            {
                if (intArray[i] != intArray[i - 1] && intArray[i] != intArray[i+1])
                   Console.WriteLine(intArray[i]);
            }
            Console.WriteLine("-------------------");

            if (intArray[intArray.Length-1] != intArray[intArray.Length-2])
                Console.WriteLine(intArray[intArray.Length - 1]);
        }
    }
}
