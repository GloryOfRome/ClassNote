using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220116
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------2D Arrays 
            //-已知数组的行数与列数，并且同时进行赋值---2维数组中每行数组中有多少元素是一样的，不可能有的里面有三个元素，有的有两个
            int[,] twoDArrays =
            {
                {1,2 },
                {3,4,},
                {5,6},
            };
            Console.WriteLine(twoDArrays[0,0]);
            Console.WriteLine("--------------------");

            foreach (int el in twoDArrays)
                Console.WriteLine(el );
            Console.WriteLine("--------------------");

            //-数组的行数与列数必须在建立初期进行设定,里面初始值为0
            int[,] anotherArray = new int[2, 3];
            Console.WriteLine(anotherArray[0, 0]);
            Console.WriteLine(anotherArray[0, 1]);
            Console.WriteLine(anotherArray[0, 2]);
            Console.WriteLine(anotherArray[1, 0]);
            Console.WriteLine(anotherArray[1, 1]);
            Console.WriteLine(anotherArray[1, 2]);
            Console.WriteLine("--------------------");


            //-------------------stacks and queues
            Console.WriteLine("STACKS");
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            Console.WriteLine("当前stack元素为");
            foreach(string el in stack)
                Console.Write($"{el}, ");
            Console.WriteLine();
            Console.WriteLine("--------------------");

            Console.WriteLine($"元素数量为{stack.Count}");
            //stack.Clear();
            //Console.WriteLine("清除所有元素后");
            //foreach (string el in stack)
            //    Console.Write($"{el}, ");
            //Console.WriteLine();
            //Console.WriteLine($"元素数量为{stack.Count}");
            Console.WriteLine("--------------------");

            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            Console.WriteLine("--------------------");

            Console.WriteLine("QUEUES");

            Queue<int> queues = new Queue<int>();
            queues.Enqueue(1);
            queues.Enqueue(2);
            queues.Enqueue(3);
            queues.Enqueue(4);
            Console.WriteLine("遍历queues,其元素为");
            foreach(int el in queues)
                Console.Write($"{el}, ");
            Console.WriteLine();
            Console.WriteLine("--------------------");
            

            


            Console.ReadLine();
        }
    }
}
