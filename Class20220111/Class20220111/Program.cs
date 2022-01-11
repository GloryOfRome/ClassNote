using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220111
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world！";
            ////System.String与上面的一样
            //char c = 'y';
            //Console.WriteLine(s);
            //Console.WriteLine();
            //Console.WriteLine(s[7]);

            ////s[11] = '.';//error 他是只读的，只能读取，不能赋值
            //string emp = "";
            //string emp1 = string.Empty;

            //if (string.IsNullOrEmpty(emp))
            //{
            //    Console.WriteLine("empty");
            //}

            ////replace替换
            //string newstr = s.Replace('L','$');//区分大小写
            //Console.WriteLine(newstr);
            //Console.WriteLine(s.Replace("ll", "2l"));

            //Console.WriteLine(emp);
            //emp = "nihao";
            //Console.WriteLine(emp);

            //s.Replace('l', '2');//打印没有变化
            //string ss = s.Replace('l', '2');//打印有变化
            //Console.WriteLine(s);
            //Console.WriteLine(ss);

            ////Trim修剪
            //string name = "          mi   ke   ";
            //Console.WriteLine(name);
            //Console.WriteLine(name.Trim());
            //Console.WriteLine(name.TrimEnd());
            //Console.WriteLine(name.TrimStart());

            //Substring取string的一部分，给出index位置
            //string s1 = s.Substring(5);
            //string s3 = s.Substring(4);
            //string s2 = s.Substring(6);
            //string s4 = s.Substring(6,3);
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);

            //Contains包含
            if(s.Contains("world"))
                Console.WriteLine("good");


            Console.ReadLine();
        }
    }
}
