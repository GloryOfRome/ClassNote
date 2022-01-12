using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_function_and_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            string aa;
            
            firstname = "Steven Clark";
            lastname = "Clark";
            aa = "Steven Clark";

            Console.WriteLine(firstname);

            //Console.WriteLine($"克隆字符串:{firstname.Clone()}");
            //// Make String Clone
            //Console.WriteLine($"比较两个字符串并返回整数值作为输出。它返回 0 表示真(相同)，1 表示假(不相同)。------{firstname.CompareTo(lastname)}");
            //Console.WriteLine($"比较两个字符串并返回整数值作为输出。它返回 0 表示真(相同)，1 表示假(不相同)。。------{firstname.CompareTo(aa)}");
            ////Compare two string value and returns 0 for true and 1 for false


            Console.WriteLine($"检查字符串值中是否存在指定的字符或字符串。---{firstname.Contains("ven")}");
            //Check whether specified value exists or not in string

            //Console.WriteLine($"检查指定的字符是否是字符串的最后一个字符。---{firstname.EndsWith("n")}"); //Check whether specified value is the last character of string
            //Console.WriteLine($"检查指定的字符是否是字符串的最后一个字符。---{firstname.EndsWith("k")}"); //Check whether specified value is the last character of string
            //Console.WriteLine($"比较两个字符串并返回布尔值作为输出。---{firstname.Equals(lastname)}");
            //Console.WriteLine($"比较两个字符串并返回布尔值作为输出。---{firstname.Equals(aa)}");
            ////Compare two string and returns true and false


            //Console.WriteLine($"---不明白---返回指定字符串的 HashValue。---{firstname.GetHashCode()}");
            //Returns HashCode of String

            //Console.WriteLine($"返回当前实例的 System.Type。---{firstname.GetType()}");
            ////Returns type of string

            //Console.WriteLine($"返回 System.String 类的 Stystem.TypeCode。---{firstname.GetTypeCode()}");
            ////Returns type of string

            //Console.WriteLine($"返回指定字符第一次出现的索引位置。---{firstname.IndexOf("e")}");
            ////Returns the first index position of specified value the first index position of specified value


            //Console.WriteLine($"当前区域性的规则将字符串转换为小写。---{firstname.ToLower()}");
            ////Covert string into lower case

            //Console.WriteLine($"当前区域性的规则将字符串转换为大写。---{firstname.ToUpper()}");
            ////Convert string into Upper case

            //Console.WriteLine($"在指定位置插入字符串或字符串中的字符---{firstname.Insert(0, "Hello ")}");
            ////Insert substring into string

            //Console.WriteLine($"---不明白---检查此字符串是否为 Unicode 规范化形式 C。---{firstname.IsNormalized()}");
            //Check Whether string is in Unicode normalization from C


            //Console.WriteLine($"返回指定字符最后一次出现的索引位置。---{firstname.LastIndexOf("e")}");
            ////Returns the last index position of specified value

            //Console.WriteLine($"返回字符串长度的字符串属性。---{firstname.Length}");
            ////Returns the Length of String


            //Console.WriteLine($"删除从开始到指定索引位置的所有字符。---{firstname.Remove(5)}");
            ////Deletes all the characters from begining to specified index.

            //Console.WriteLine($"替换字符---{firstname.Replace('e', 'i')}"); 
            //// Replace the character

            //string[] split = firstname.Split(new char[] { 'e' });
            ////Split the string based on specified value
            //Console.WriteLine(split[0]);
            //Console.WriteLine(split[1]);
            //Console.WriteLine(split[2]);

            //Console.WriteLine($"检查字符串的第一个字符是否与指定字符相同。---{firstname.StartsWith("S")}"); 
            ////Check wheter first character of string is same as specified value

            //Console.WriteLine($"返回指定索引之间的字符串。---{firstname.Substring(2, 5)}");
            ////Returns substring

            //Console.WriteLine($"---不明白---将字符串转换为 char 数组。---{firstname.ToCharArray()}");
            //Converts an string into char array.

            //Console.WriteLine($"它从字符串的开头和结尾删除额外的空格。---{firstname.Trim()}");
            ////It removes starting and ending white spaces from string.
        }
    }
}
