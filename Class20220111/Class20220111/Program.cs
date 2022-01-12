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

            //s[11] = '.';//error 他是只读的，只能读取，不能赋值
            //string emp = "";
            //string emp1 = string.Empty;

            //if (string.IsNullOrEmpty(emp))
            //{
            //    Console.WriteLine("empty");
            //}

            //if (string.IsNullOrEmpty(emp1))
            //{
            //    Console.WriteLine("empty");
            //}

            //replace替换
            //string newstr = s.Replace('L', '$');//区分大小写
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
            //if(s.Contains("ll"))
            //    Console.WriteLine("good");
            //else
            //    Console.WriteLine("bad");

            //exercise-练习
            //1---intput:"Hello"---output"olleH"
            //string aa = "NiHao";
            //char[] bb = aa.ToCharArray();
            //for(int i = 0; i < bb.Length/2; i++)
            //{
            //    char temp = ' ';
            //    temp = bb[i];
            //    bb[i] = bb[bb.Length - 1-i];
            //    bb[bb.Length - 1-i] = temp;
            //}

            //foreach (char el in bb)
            //    Console.Write(el);
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            ////for(int i=0;i<bb.Length;i++)
            ////    Console.WriteLine(bb[i]);
            ////Console.WriteLine("----------------------------");
            //FindPartString("Hello");
            //Console.WriteLine();
            //FindPartStringOther("Hello");
            //Console.WriteLine(ReverseString("Hello"));

            ////better code
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //sb.Append(" World");
            //Console.WriteLine(sb);
            //for (int i = 0; i < 1000; i++)
            //    sb.Append(i);
            //Console.WriteLine(sb);

            string s2 = "this is a sentence, a long one";
            //char[] sperators = new char[] { ' ', ',', '\t', 'e' };
            //string[] splittedString = s2.Split(sperators);
            //foreach (string st in splittedString)
            //    Console.WriteLine(st);

            //Console.WriteLine(s2.Substring(s2.IndexOf(',')));
            //Console.WriteLine(s2.Substring(s2.IndexOf(',')+1));
            //Console.WriteLine(s2.Substring(s2.IndexOf(',')+2));

            //string str = "tHis Is a SEntence";//将单词的第一个字母变为大写
            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.Substring(0,1).ToUpper());
            //Console.WriteLine(str.Substring(0,1).ToUpper()+ str.Substring(1,str.Length-1).ToLower());
            //Console.WriteLine(str.Substring(0,1).ToUpper()+ str.Substring(1).ToLower());
            //RightWriteOther(str);
            //RightWrite(str);

            string str = "Hi I am learning clsadsa# in the class";
            string wordSelected = "Cl";
            Console.WriteLine(GetAllWordsStartingWith(str, wordSelected));
            Console.WriteLine("------------------------");

            char[] separator = new char[] { ' ', ',', '.', ':', '\t' };
            string[] words = str.Split(separator);
            string[] result = new string[words.Length];
            int index = 0;
            foreach (string word in words)
            {
                if (word.ToUpper().StartsWith(wordSelected.ToUpper()))
                {
                    result[index] = word;
                    Console.WriteLine(result[index]);
                    index++;
                }
            }
            Console.WriteLine("------------------------");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            //char[] chars = new char[] { ' ', ',', '.', ':', '\t' };
            //string[] words = s3.Split(chars);
            //List<string> result = new List<string>();
            //for(int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].ToUpper().StartsWith(ch3.ToUpper()))
            //    {
            //        result.Add(words[i]);
            //    }
            //}
            //foreach(string el in result)
            //    Console.WriteLine(el);


            //Console.WriteLine(s3.Split(' '));

            //string s4 = "Java and Javascript are like car and carpet";
            //string s5 = "Java";
            //GetAllWordsStartingWith(s4, s5);

            //bool b = CheckString("car", "rca");
            //Console.WriteLine(b);

            //string s1 = "car";
            //string s2 = "rca";
            //bool b = s1.StartsWith(s2);
            //Console.WriteLine(b);

            //Console.ReadLine();
        }

        //static bool CheckString(string s1, string s2)
        //{
        //    if (s1.Length == s2.Length && s1.StartsWith(s2))
        //        return true;
        //}

        static string GetAllWordsStartingWith(string str, string wordSelected)
        {
            char[] separator = new char[] { ' ', ',', '.', ':', '\t' };
            string[] words = str.Split(separator);
            string[] result = new string[words.Length];
            int index = 0;
            foreach(string word in words)
            {
                if (word.ToUpper().StartsWith(wordSelected.ToUpper()))
                {
                    result[index] = word;
                    index++;
                }
            }
            return string.Join(",",result);
        }

        static void RightWriteOther(string str)
        {
            string newstr = str.ToLower();
            Console.WriteLine(newstr);
            Console.WriteLine(char.ToUpper(newstr[0]) + newstr.Substring(1, newstr.Length - 1));
        }

        static void RightWrite(string str)
        {
            string newStr = str.ToUpper();

            char[] chars = new char[] { ' ' };
            string[] splittedString = str.Split(chars);
            for(int i=1;i< splittedString.Length; i++)
            {
                //splittedString[0]=char.ToUpper(splittedString[0][0])
                splittedString[i] = splittedString[i].ToLower();
            }
            foreach (string el in splittedString)
            {
                Console.Write ($"{el} ");
            }
        }

        static string ReverseString(string str)
        {
            //str:"Hello",chars:{'H','e','l','l','o'}
            char[] chars = str.ToCharArray();

            //{'H','e','l','l','o'}
            //{'o','e','l','l','H'}
            //{'o','l','l','e','H'}
            for (int i =0; i <chars.Length/2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[chars.Length -i- 1];
                chars[chars.Length -i- 1] = temp;
            }
            return new string(chars);
        }



        static void FindPartString(string str)
        {
            for(int i=str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        static string FindPartStringOther(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newStr += str[str.Length-1-i];
            }
            return newStr;
        }


    }
}
