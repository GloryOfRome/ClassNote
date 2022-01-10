using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable_HashSet_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Hashtable
            Hashtable table = new Hashtable();
            //添加
            table.Add("小明", new Person() { Name = "小明" });
            table.Add("suiyi", new Person() { Name = "xiaogou", Age = 18 });
            table.Add("随意", new Person() { Name = "小狗", Age = 28 });
            table.Add("shabi", new Person() { Name = "傻逼" });

            //保存哈希表中元素的个数.
            Console.WriteLine(table.Count);

            //遍历---键
            //showElKey(table);

            //遍历---值
            //showElValue(table);

            //直接遍历
            //showElTable(table);

            //判断是否有指定的键
            Console.WriteLine(findKey(table, "小明"));
            Console.WriteLine(findKey(table, "小狗"));
            Console.WriteLine("--------------------");

            //判断是否有指定的值
            Console.WriteLine(findValue(table, "小明"));
            Console.WriteLine(findValue(table, "小狗"));

            //删除
            table.Remove("随意");
            //table.Clear();

            ////再次遍历
            //showElTable(table);


            # endregion
        }


        //--不明白---判断是否有指定的值
        static bool findValue(Hashtable table, string value)
        {
            bool b = table.ContainsValue(value);
            return b;
        }

        //判断是否有指定的键
        static bool findKey(Hashtable table,string key)
        {
            bool b = table.ContainsKey(key);
            return b;
        }
        
        //直接遍历
        static void showElTable(Hashtable table)
        {
            foreach (Object obj in table)
            {
                DictionaryEntry en = (DictionaryEntry)obj;
                Console.WriteLine($"this is keys: {en.Key}");
                Console.WriteLine($"this is values: {en.Value}");
                Console.WriteLine("--------------------");
            } 
        }

        //遍历---值
        static void showElValue(Hashtable table)
        {
            foreach (Object obj in table.Values)//因为值得内容元素不止一个，需要建立对象，再将每个对象的元素打印
            {
                Person ele = (Person)obj;
                Console.WriteLine($"Name: {ele.Name},Age: {ele.Age}" );

            }
        }

        //遍历---键
        static void showElKey(Hashtable table)
        {
            foreach (Object obj in table.Keys)
                Console.WriteLine($"{table[obj]} {obj}");
        }
    }
}
