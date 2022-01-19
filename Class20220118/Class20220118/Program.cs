using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220118
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1
            Stack<int> st = new Stack<int>();
            st.Push(-10);
            st.Push(3);
            st.Push(7);
            st.Push(4);

            //int target = 7;

            //GetInt(st, target);
            //Console.WriteLine("-------");

            //EX2
            //RemoveMinimun(st);
            //foreach (int el in temp2)
            //    Console.WriteLine(el); 

            /*EX3
             *Check if a string has balanced parentheses or not 
              Hi (There) ((I am using C#)) => true 
              Hi (There, I am using C#)) => false 
              ((Hi (There, I am using c#)) => false 
              ))) Hi ((( => false  
              How can you improve the solution to support different types of scopes? 
              {}[]() 
             * **/
            //string str = "Hi (There) ((I am using C#))";
            //string sentence = "Hi (There) ((I am using C#))";
            ////Console.WriteLine(BalancedParentheses(str));
            //Console.WriteLine(CheckBalanceParentheses(sentence));

            /*EX4
             Is it possible to find a specific value within a sorted List in Less than O(n) time? 
             If O(n) is achieved by iterating through a list once, 
             then achieving Lower complexity must somehow avoid iterating over an entire 
             List to find a value 
             Can you think of a way how this might be done? 
             Is it important if the list is sorted or not? 
             List: 2,4,6,7,8,9,10,14, 20, 22, 60, 90,100 o(logn) 
             -check the mid number
             -if target equals to mid, return true 
             -if the target is less than mid, then the new array is of Left of mid (new end is mid-1) 
             - if the target is greater than mid, then new array is of right of mid (new start is mid+1) 
             * **/
            List<int> list1 = new List<int>() { 2, 4, 6, 7, 8, 9, 10, 14, 20, 22, 60, 90, 100 };
            
            int target = 90;
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Remove all except last 2
            int remove = Math.Max(0, list.Count - 2);
            list.RemoveRange(0, remove);

            //foreach (int i in list)
            //{
            //    Console.Write(i);
            //}

            FindNumber(list, target);

        }
        //EX4
        static void FindNumber(List<int> list,int target)
        {
            int index = 0;
            int length = list.Count;

            //if (target > list[length / 2] && length % 2 == 0)
            //{
            //    list.RemoveRange(0, (length / 2) - 1);
            //    Console.WriteLine((length / 2) - 1);
            //}
            if (target > list[length / 2] && length % 2 != 0)
            {
                list.RemoveRange(0, (length / 2));
                Console.WriteLine(length / 2);

            }

            //while (list.Count<4)
            //{
            //    if (target > list[length / 2] && length % 2 == 0) 
            //    {
            //        list.RemoveRange(0, (length / 2)-1);
            //        Console.WriteLine((length / 2) - 1);
            //    }
            //    //if (target > list[length / 2] && length % 2 != 0)
            //    //{
            //    //    list.RemoveRange(0, (length / 2) );
            //    //    Console.WriteLine(length / 2);
            //    //}
            //    //if (target == list[length / 2])
            //    //{
            //    //    Console.WriteLine($"数字{target}在{list[length / 2 - 1]}和{list[length / 2 + 1]}之间");
            //    //}
            //}
        }

        //EX3
        //static bool BalancedParentheses(string str)
        //{
        //    Queue<Char> tempQu = new Queue<char>();
        //    //Console.WriteLine(tempQu.Count);
        //    Char typeOfBalanced = ' ';
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == '(')
        //        {
        //            tempQu.Enqueue(str[i]);
        //        }
        //        if(str[i] == ')')
        //        {
        //            typeOfBalanced = tempQu.Dequeue();
        //            if (typeOfBalanced != '(')
        //            {
        //                return false;
        //            }
        //        }
        //        return false;
        //    }
        //    if (tempQu.Count > 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //同学的
        static bool CheckBalanceParentheses(string sentence)
        {
            Stack<Char> sb = new Stack<char>();
            Char typeOfBarackets = ' ';
            for(int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == '(')
                {
                    sb.Push(sentence[i]);
                }

                if (sentence[i] == ')')
                {
                    typeOfBarackets = sb.Pop();
                    if (typeOfBarackets != '(')
                    {
                        return false;
                    }
                }
            }
            if (sb.Count > 0)
                return false;
            return true;
        }

        //EX2
        static void RemoveMinimun(Stack<int> st)
        {
            Stack<int> temp = new Stack<int>();
            int tempMax = int.MaxValue;
            while (st.Count > 0)
            {
                int tempInt = st.Pop();
                temp.Push(tempInt);
                if (tempInt < tempMax)
                {
                    tempMax = tempInt;
                    //temp.Push(tempInt);
                }
            }

            while (temp.Count > 0)
            {
                int item = temp.Pop();
                if (item > tempMax)
                {
                    st.Push(item);
                    Console.WriteLine(item);
                }
            }
        }

        //EX1

        static void GetInt(Stack<int> st, int target)
        {
            Stack<int> temp = new Stack<int>();
            Console.WriteLine("Pringting stack");
           
            while (st.Count > 0)
            {
                int item = st.Pop();
                if (item != target)
                {
                    temp.Push(item);
                }
            }
            Console.WriteLine("End of stack...");

            while (temp.Count > 0)
            {
                int item = temp.Pop();
                st.Push(item);
                Console.WriteLine(item);
            }

            
        }
    }
}
