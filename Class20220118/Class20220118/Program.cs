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

            int target = 7;

            //GetInt(st, target);
            //Console.WriteLine("-------");

            //EX2
            RemoveMinimun(st);
            //foreach (int el in temp2)
            //    Console.WriteLine(el); 


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
