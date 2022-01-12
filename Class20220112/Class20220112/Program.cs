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
            string[] str = new string[] { "werew", "dscxv", "23" };
            Console.WriteLine(str);
            Console.WriteLine(string.Join(" ",str));
            Console.WriteLine(string.Join("--",str));
        }
    }
}
