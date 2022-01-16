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
            //2D Arrays 
            //-已知数组的行数与列数，并且同时进行赋值---2维数组中每行数组中有多少元素是一样的，不可能有的里面有三个元素，有的有两个
            int[,] twoDArrays =
            {
                {1,2 },
                {3,4,},
                {5,6},
            };
            Console.WriteLine(twoDArrays[0,0]);
            Console.WriteLine("--------------------");

            //-数组的行数与列数必须在建立初期进行设定,里面初始值为0
            int[,] anotherArray = new int[2, 3];
            Console.WriteLine(anotherArray[0, 0]);
            Console.WriteLine(anotherArray[0, 1]);
            Console.WriteLine(anotherArray[0, 2]);
            Console.WriteLine(anotherArray[1, 0]);
            Console.WriteLine(anotherArray[1, 1]);
            Console.WriteLine(anotherArray[1, 2]);

            Console.ReadLine();
        }
    }
}
