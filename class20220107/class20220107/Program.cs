﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace class20220107
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            int[] arr = new int[3];

            ////read the value of this array from the user
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"please enter the {i} value");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //PrintIntgArray(arr);
            ////1---
            //string[] strArray = new string[] { "1", "2", "3" };
            //PrintStirngArray(strArray);

            ////2---
            //int[] intArray = new int[] { 2, 4, 5, 2, 8, 2 };
            //Console.WriteLine("please enter a number");
            //int num = int.Parse(Console.ReadLine());
            //int countNumber = CountNumberInArray(intArray, num);
            //Console.WriteLine(countNumber);

            ////3--
            //Console.WriteLine("please enter a number");
            //int num = int.Parse(Console.ReadLine());

            //bool completeNmber = CompleteNmber(num);
            //Console.WriteLine(completeNmber);

            ////4--
            //CompleteNumbersInRang(1, 1000);

            ////5--
            //bool b = AreFriend(220, 284);
            //Console.WriteLine(b);

            ////6--
            //PrintAllFriendsInRange(1, 1000);

            ////用Switch语句将所有method以菜单显示
            //Console.WriteLine("please enter a Number:");
            //int option = int.Parse(Console.ReadLine());
            //while (option != 0)
            //{
            //    switch (option)
            //    {
            //        case 1:
            //            Console.WriteLine("you chose complete number, enter a number:");
            //            int num = int.Parse(Console.ReadLine());
            //            Console.WriteLine(CompleteNmber(num));
            //            break;
            //        case 2:
            //            Console.WriteLine("you chose friends number, enter two numbers:");
            //            int n1 = int.Parse(Console.ReadLine());
            //            int n2 = int.Parse(Console.ReadLine());
            //            Console.WriteLine(AreFriend(n1, n2));
            //            break;
            //        default:
            //            Console.WriteLine("wrong oprion...");
            //            break;
            //    }
            //    Console.WriteLine("if you want to stop, you can enter number 0");
            //    option = int.Parse(Console.ReadLine());
            //}
            int[] intArray = new int[7] { 1, 3, 1, 4, 5, 5, 6 };
            FindDuplicateValue(intArray);
        }
        //7---write a function to find the duplicate values inside an array of integer valuse
        //return the resule in a new array.
        //input:{1,3,1,4,5,5,6}
        //output:{1,5}
        public void FindDuplicateValue(int[] intArray)
        {
            ArrayList arrayList = new ArrayList();
            int index = 0;
            for (int i = 0; i < intArray.Length-1; i++)
            {
                for (int j = i+1; j < intArray.Length; j++)
                {
                    if (intArray[i] == intArray[j])
                    {
                        arrayList[index] = intArray[i];
                        index++;
                    }
                }
            }
            foreach(var el in arrayList)
                Console.WriteLine(el);
        }

        //6---write a function to print all friend number in range
        static void PrintAllFriendsInRange(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                    if (AreFriend(i,j))
                        Console.WriteLine($"{i}---{j}");
            }
            Console.WriteLine("that is all");
        }
        //5---the friend number
        //x,y
        //sum(divisors x)==y && sum(divisors y)==x,then x and y are friends
        static bool AreFriend(int num1,int num2)
        {
            return (DivSum(num1) == num2 && DivSum(num2) == num1);//与下面相同的效果
            //if (DivSum(num1) == num2 && DivSum(num2) == num1)
            //    return true;
            //else
            //    return false;
        }

        //写一个方法求x除数的和
        static int DivSum(int num)
        {
            int divisorSum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    divisorSum += i;
            }
            return divisorSum;
        }

        //4---write a function to print all complete number in range
        static void CompleteNumbersInRang(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                bool b = CompleteNmber(i);
                if(b)
                    Console.WriteLine(i);
            }
        }

        //3---write a funtion to see if an umber is complete
        //the number is equal to the sum of its divisors
        //12:1,2,3,4,6
        //6:1,2,3
        //28:1,2,4,7,14
        static bool CompleteNmber(int num)
        {
            int divisorSum = 0;
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                    divisorSum += i;
            }
            //int someone = (int)num / 2;//测试
            //Console.WriteLine($"num/2 = {someone}");
            //Console.WriteLine($"the sum of its divisors is {divisorSum}");
            if (divisorSum == num)
                return true;
            else
                return false;

        }
        //2---write a method to return the frequency of a number in an interger array
        //{2,4,5,2,8,2} freq(2) =3
        static int CountNumberInArray(int[] intArray,int freq)
        {
            int countSum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == freq)
                    countSum++;
            }
            return countSum;

        }

        //1---write a method to print a String Array
        static void PrintStirngArray(string[] strArray)
        {
            for(int i=0;i< strArray.Length;i++)
                Console.WriteLine(strArray[i]);
        }

        //write a method to print a Int Array
        static void PrintIntgArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
        //写一个可以输入array元素的方法
        static string[] WriteArray()
        {
            Console.WriteLine("How nuch number do you want in your array");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            Console.WriteLine("please enter a element of array");

            string[] arr = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"please enter the {i} string");
                arr[i] = Console.ReadLine();
            }
            return arr;
        }
    }
}
