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

            //遍历---键
            //showElKey(table);

            //遍历---值
            showElValue(table);

            //直接遍历
            showElTable(table);

            //删除
            table.Remove("随意");


            # endregion
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

        //---不明白---遍历---值
        static void showElValue(Hashtable table)
        {
            foreach(Object obj in table.Values)
                Console.WriteLine(obj);
        }

        //遍历---键
        static void showElKey(Hashtable table)
        {
            foreach (Object obj in table.Keys)
                Console.WriteLine($"{table[obj]} {obj}");
        }
    }
}
