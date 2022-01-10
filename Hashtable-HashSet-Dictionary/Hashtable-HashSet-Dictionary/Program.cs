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
            Console.WriteLine("---------Hashtable---------");
            Hashtable table = new Hashtable();
            //添加
            table.Add("小明", new Person() { Name = "小明" });
            table.Add("suiyi", new Person() { Name = "xiaogou", Age = 18 });
            table.Add("随意", new Person() { Name = "小狗", Age = 28 });
            table.Add("shabi", new Person() { Name = "傻逼" });

            //保存哈希表中元素的个数.
            //Console.WriteLine(table.Count);

            //遍历---键
            //showElKey(table);

            //遍历---值
            //showElValue(table);

            //直接遍历
            //showElTable(table);

            ////判断是否有指定的键
            //Console.WriteLine(findKey(table, "小明"));
            //Console.WriteLine(findKey(table, "小狗"));
            //Console.WriteLine("--------------------");

            ////判断是否有指定的值
            //Console.WriteLine(findValue(table, "小明"));
            //Console.WriteLine(findValue(table, "小狗"));

            //删除
            table.Remove("随意");
            //table.Clear();

            ////再次遍历
            //showElTable(table);


            #endregion

            #region 2. HashSet
            Console.WriteLine("---------HashSet---------");

            HashSet<string> companyTeams = new HashSet<string>()
            { "Ferrari", "McLaren", "Toyota", "BMW", "Renault", "Honda" };

            HashSet<string> traditionalTeams = new HashSet<string>()
            { "Ferrari", "McLaren" };

            HashSet<string> privateTeams = new HashSet<string>()
            { "Red Bull", "Toro Rosso", "Spyker", "Super Aguri" };

            ////1---值不能重复
            //DuplicateValue(privateTeams, companyTeams);

            ////2---验证包含与被包含--IsSubsetOf()--IsSupersetOf()
            //CheckEle(traditionalTeams, companyTeams);

            //3---参数传送的集合中至少有一个元素与集中的元素相同，Overlaps()就返回true
            //CheckOverlaps(traditionalTeams, privateTeams);

            ////4-1---UnionWith()方法把传送为参数的集合中的所有元素添加到集中
            ////4-2---ExceptWith()方法把一个集合作为参数，从集中删除该集合中的所有元素
            //CheckUnionWit(traditionalTeams, privateTeams, companyTeams);

            //5---参数传送的集合和集包含完全相同的元素，方法SetEquals()就返回true
            CheckSetEquals(traditionalTeams);
            #endregion
        }

        #region 1.Hashtable method
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
        #endregion

        #region
        //5---参数传送的集合和集包含完全相同的元素，方法SetEquals()就返回true
        static void CheckSetEquals(HashSet<string> traditionalTeams)
        {
            HashSet<string> temporaryHashSet = new HashSet<string>();
            temporaryHashSet.UnionWith(traditionalTeams);
            if(temporaryHashSet.SetEquals(traditionalTeams))
                Console.WriteLine("the team is same");
        }


        //4-1---UnionWith()方法把传送为参数的集合中的所有元素添加到集中
        static void CheckUnionWit(
            HashSet<string> traditionalTeams, 
            HashSet<string> privateTeams,
            HashSet<string> companyTeams)
        {
            HashSet<string> allTeams = new HashSet<string>(companyTeams);
            allTeams.UnionWith(privateTeams);
            allTeams.UnionWith(traditionalTeams);
            Console.WriteLine();
            Console.WriteLine("all teams");
            foreach (var team in allTeams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("----------------------------");
            //4-2---ExceptWith()方法把一个集合作为参数，从集中删除该集合中的所有元素
            allTeams.ExceptWith(privateTeams);
            Console.WriteLine();
            Console.WriteLine("no private team left");
            foreach (var team in allTeams)
            {
                Console.WriteLine(team);
            }
        }

        //3---参数传送的集合中至少有一个元素与集中的元素相同，Overlaps()就返回true
        static void CheckOverlaps(HashSet<string> traditionalTeams, HashSet<string> privateTeams)
        {
            traditionalTeams.Add("Williams");
            privateTeams.Add("Williams");
            if (privateTeams.Overlaps(traditionalTeams))
            {
                Console.WriteLine("At least one team is " + "the same with the traditional " + "and privateteams");
            }
        }


        //2-验证超集和子集
        static void CheckEle(HashSet<string> traditionalTeams, HashSet<string> companyTeams)
        {
            if (traditionalTeams.IsSubsetOf(companyTeams))
            {
                Console.WriteLine("traditionalTeams is " + "subset of companyTeams");
            }

            if (companyTeams.IsSupersetOf(traditionalTeams))
            {
                Console.WriteLine("companyTeams is a superset of " + "traditionalTeams");
            }
        }
        //1---值不能重复
        static void DuplicateValue(HashSet<string> privateTeams, HashSet<string> companyTeams)
        {
            if (privateTeams.Add("Williams"))
                Console.WriteLine("Williams added");
            if (!companyTeams.Add("McLaren"))
                Console.WriteLine("McLaren was already in this set");
        }
        #endregion
    }
}
