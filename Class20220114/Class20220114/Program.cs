using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary<int, string> ");
            Dictionary<int, string> numbersToDictionary = new Dictionary<int, string>();

            numbersToDictionary.Add(1, "one");//添加
            numbersToDictionary.Add(2, "two");
            numbersToDictionary.Add(3, "three");
            //numbersToDictionary.Add(2, "two and three");//虽然是错误，但是没有红线
            AddToDicrionary(numbersToDictionary, 2, "good");

            //循环遍历--比较特殊
            foreach (KeyValuePair<int,string> el in numbersToDictionary)
                Console.WriteLine($"key:{el.Key}，value:{el.Value}");

            Console.WriteLine(numbersToDictionary[2]);//显示value
            //Console.WriteLine(numbersToDictionary("two"));//显示value

            Console.WriteLine("--------------------");
            Console.WriteLine("Dictionary<string, string> ");

            Dictionary<string, string> englishToDictionary = new Dictionary<string, string>();
            englishToDictionary.Add("ss", "asdasfas1");
            englishToDictionary.Add("aa", "asdasfas2");
            PrintDicrionary(englishToDictionary);
            Console.WriteLine( englishToDictionary.ElementAt(1).Value);
            Console.WriteLine(englishToDictionary["ss"]);

            //练习-1
        }
        //练习-1
        static void StudentsAndGrades(Dictionary<int,int> dict,int id,int grades)
        {
            if (dict.ContainsKey(id))
            {
                dict[id] = grades;
            }
            else
            {
                dict.Add(id, grades);
            }
        }

        static void PrintDicrionary(Dictionary<int, string> numbersToDictionary)
        {
            foreach (KeyValuePair<int, string> el in numbersToDictionary)
                Console.WriteLine($"key:{el.Key}，value:{el.Value}");
        }

        static void PrintDicrionary(Dictionary<string, string> dict)
        {
            foreach(var pair in dict)
                Console.WriteLine($"key:{pair.Key}，value:{pair.Value}");
        }

        static void AddToDicrionary(Dictionary<int, string> dict,int key,string value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
            }
            else
            {
                dict.Add(key, value);
            }
        }

    }
}
