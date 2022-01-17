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
            //Console.WriteLine("Dictionary<int, string> ");
            Dictionary<int, string> numbersToDictionary = new Dictionary<int, string>();

            numbersToDictionary.Add(1, "one");//添加
            numbersToDictionary.Add(2, "two");
            numbersToDictionary.Add(3, "three");
            //numbersToDictionary.Add(2, "two and three");//虽然是错误，但是没有红线
            //AddToDicrionary(numbersToDictionary, 2, "good");

            ////循环遍历--比较特殊
            //foreach (KeyValuePair<int,string> el in numbersToDictionary)
            //    Console.WriteLine($"key:{el.Key}，value:{el.Value}");

            //Console.WriteLine(numbersToDictionary[2]);//显示value
            ////Console.WriteLine(numbersToDictionary("two"));//显示value

            //Console.WriteLine("--------------------");
            //Console.WriteLine("Dictionary<string, string> ");

            Dictionary<string, string> englishToDictionary = new Dictionary<string, string>();
            //englishToDictionary.Add("ss", "asdasfas1");
            //englishToDictionary.Add("aa", "asdasfas2");
            //PrintDicrionary(englishToDictionary);
            //Console.WriteLine( englishToDictionary.ElementAt(1).Value);
            //Console.WriteLine(englishToDictionary["ss"]);
            //Console.WriteLine("--------------------");
            //Console.WriteLine("练习-1");

            //练习-1
            
            //Console.WriteLine("Dictionary<int, int> ");
            ////StudentsAndGrades(Dictionary<int, int> dict, int id, int grades)
            //Console.WriteLine("--------------------");
            //Console.WriteLine("练习-2");

            //练习-2
            //Dictionary<string, int> dict2 = new Dictionary<string, int>();
            ////AddToDicrionary(dict2,"bob", 98);
            ////PrintStudentGrade(dict2);
            //Console.WriteLine("--------------------");

            //练习-3
            /*In a list of numbers (those number are between 1 and 10 only)
             * 在数字列表中（这些数字仅在 1 到 10 之间）
             * find the most frequent number in O(n) time.
             * 在 O(n) 时间内找到最频繁的数字。
             * 
             * example:
             * input:{ 1, 5, 7, 10, 1, 7, 1, 9 }
             * output:1
             * **/
            //Console.WriteLine("练习-3");
            List<int> list3 = new List<int> { 1, 5, 7, 10, 1, 7, 1, 9 };
            //PrintFrequencyNUmber(list3);

            Console.WriteLine("练习-4");
            /*
             For a dictionary which has ("Product Name", Price) as key-value pairs,
             write the following functions:
              - Display all products with their prices
              - Add a product
              - Update a product price
              - Show all products with prices more than a certain price
              - Get the most expensive product
              - Display all products ordered by price (using built-in C# methods and other types is allowed)
              - A function to create another dictionary for all products sharing the same price,
                where the key is the price and the value is a list of products names with that price
             
             */

            Dictionary<string, int> dic4 = new Dictionary<string, int>();
            dic4.Add("苹果电脑", 100);
            dic4.Add("海信电视", 200);
            dic4.Add("华为手机", 200);
            dic4.Add("西门子冰箱", 300);
            dic4.Add("格力空调", 300);
            dic4.Add("音响", 400);

            //4-1 Display all products with their prices显示所有产品及其价格
            DisplayProductsPrices(dic4);
            Console.WriteLine("--------------------");


            //4-2 Add a product 添加产品
            AddProduct(dic4, "惠普电脑真差");
            DisplayProductsPrices(dic4);
            Console.WriteLine("--------------------");

            //4-3 Update a product price 更新产品价格
            UpdateProducPrice(dic4, "惠普电脑真差", 800);
            DisplayProductsPrices(dic4);
            Console.WriteLine("--------------------");

            //4-4 Show all products with prices more than a certain price 显示价格超过某个价格的所有产品
            MoreThanCertainPrice(dic4, 300);
            Console.WriteLine("--------------------");

            //4-5 Get the most expensive product获得最昂贵的产品
            GetTheMostExpensiveProduct(dic4);
            Console.WriteLine("--------------------");

            //4-6 Display all products ordered by price (using built-in C# methods and other types is allowed)
            //显示按价格排序的所有产品(允许使用内置的c#方法和其他类型)
            OrderedByPrice(dic4);
            Console.WriteLine("--------------------");

            //4-7 A function to create another dictionary for all products sharing the same price,
            //为共享相同价格的所有产品创建另一个字典的功能，
            //where the key is the price and the value is a list of products names with that price
            //其中键是价格，值是具有该价格的产品名称列表
            CreateAnotherDictionary(dic4);
            List<string> aa = new List<string>();
            aa ={ "aasdas","dfdsfsd","hgfd"};
            Dictionary<int, List<string>> bb = new Dictionary<int, List<string>>();
            bb.Add(1, aa);
            foreach (KeyValuePair<int, List<string>> el in bb)
            {
                Console.WriteLine( $"{el.Value}--{el.Key}");
            }
        }


        //4-7 A function to create another dictionary for all products sharing the same price,
        //为共享相同价格的所有产品创建另一个字典的功能，
        //where the key is the price and the value is a list of products names with that price
        //其中键是价格，值是具有该价格的产品名称列表
        static void CreateAnotherDictionary(Dictionary<string, int> dic4)
        {
            Dictionary<int, List<string>> newDictionary = new Dictionary<int, List<string>>();
            List<string> productsList = new List<string>();
            for (int i = 0; i < dic4.Count; i++)
            {

            }
                foreach (KeyValuePair<string,int> el in dic4)
            {
                //if(el.Value==el.Value)
            }
        }


        //4-6 Display all products ordered by price (using built-in C# methods and other types is allowed)
        //显示按价格排序的所有产品(允许使用内置的c#方法和其他类型)

        static void OrderedByPrice(Dictionary<string, int> dic4)
        {
            int[] intArray = new int[dic4.Count];
            List<int> list = new List<int>();
            //HashSet<int> tempInt = new HashSet<int>();
            //List<List<string>> tempString = new List<List<string>>();
            int index = 0;
            //int num1 = 0;

            foreach (KeyValuePair<string, int> el in dic4)//将价格放入array
            {
                intArray[index] = el.Value;
                index++;
            }
            Array.Sort(intArray);//排序

            int min = int.MinValue;
            for (int i = 1; i < intArray.Length; i++)
            {
                min = intArray[0];
                if (intArray[i] == min)
                {
                    
                }
            }

                foreach (int el in intArray)
                Console.WriteLine(el);

        }

        //4-5 Get the most expensive product获得最昂贵的产品
        static void GetTheMostExpensiveProduct(Dictionary<string, int> dic4)
        {
            string tempProduct = " ";
            int tempPrice = 0;
            foreach(KeyValuePair<string,int> el in dic4)
            {
                if (el.Value > tempPrice)
                {
                    tempPrice = el.Value;
                    tempProduct = el.Key;
                }
            }
            Console.WriteLine($"the most expensive product is {tempProduct}");
        }



        //4-4 Show all products with prices more than a certain price 显示价格超过某个价格的所有产品
        static void MoreThanCertainPrice(Dictionary<string, int> dic4,int price)
        {
            int index = 0;
            List<string> moreThanCertainPrice = new List<string>();
            foreach(KeyValuePair<string,int> el in dic4)
            {
                if (el.Value > price)
                {
                    moreThanCertainPrice.Add(el.Key);
                    index++;
                }
            }
            foreach(string el in moreThanCertainPrice)
                Console.WriteLine($"the {el}'s price more than {price}");
        }

        //4-3 Update a product price 更新产品价格
        static void UpdateProducPrice(Dictionary<string, int> dic4, string product,int price)
        {
            AddToDicrionary(dic4,product, price);
        }


        //4-2 Add a product 添加产品
        static void AddProduct(Dictionary<string, int> dic4,string product)
        {
            dic4.Add(product, 0);
        }

        //4-1 Display all products with their prices显示所有产品及其价格
        static void DisplayProductsPrices(Dictionary<string, int> dic4)
        {
            foreach(KeyValuePair<string,int> el in dic4)
            {
                Console.WriteLine($"the products is {el.Key},the price is {el.Value}");
            }
        }


        //练习-3
        static void PrintFrequencyNUmber(List<int> list3)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Console.WriteLine($"list3[0]:{list3[0]}");
                //dict.Add(list3[0], 1);
                //dict.Add(list3[1], 1);
                //dict.Add(list3[2], 1);
                //dict.Add(list3[3], 1);
                //dict.Add(list3[4], 1);
                //dict.Add(list3[5], 1);
            for (int i = 0; i < list3.Count; i++)
            {
                if (dict.ContainsKey(dict[list3[i]]))
                {
                dict.Add(list3[i], 1);
                    dict[list3[i]] += 1;
                }


                //dict.Add(list3[i], 1);
                //if (dict.ContainsKey(list3[i]))
                //{
                //    dict[list3[i]] += 1;
                //}
                //Console.WriteLine(list3[i]);
            }

            foreach (KeyValuePair<int,int> el in dict)
                Console.WriteLine($"key:{el.Key}，value:{el.Value}");
        }

        //练习-2
        static void PrintStudentGrade(Dictionary<string, int> dict2)
        {
            Console.WriteLine($"the student id is {dict2.Keys}, the grade is{dict2.Values}");
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
            Console.WriteLine($"the student's number is{id},he grade is{grades}");
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

        static void AddToDicrionary(Dictionary<string, int> dict, string key, int value)
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
