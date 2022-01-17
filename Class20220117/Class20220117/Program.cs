using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220117
{
    class Program
    {
        static void Main(string[] args)
        {
            ////The quick browm fox jumps over the lazuy dog
            //string inputString = "The quick browm fox jumps over the lazuy dog";
            //ContainsAllEnglishLetters(inputString);
            ////转成char[]
            //string str = "The quick browm fox jumps over the lazuy dog";

            //char[] cha = str.ToLower().ToArray();
            //Array.Sort(cha);

            //for(int i = 0; i < cha.Length; i++)
            //{
            //    if (Convert.ToInt32(cha[i])== Convert.ToInt32(cha[i+1]))
            //    {

            //    }
            //}
            //foreach(char el in cha)
            //{
            //    Console.WriteLine(el); ;
            //    //    Console.WriteLine(Convert.ToInt32(el));
            //}
            int[,] intArray = new int[3, 3]
            {
                {1,5,10 },
                {7,10,2 },
                {9,10,5 }
            };

            //练习
            /*
                a 2D array represents users/movies ratings, 2D数组表示用户/电影评分，
                where the row is the user and the column is the movie, 行是用户，列是电影，
                write the following functions: 编写以下函数:
                Get all movies rated 10 by 1 user at Least 
                获得所有电影评级为10个用户至少
                Get the average rating for each movie 
                获得每部电影的平均评分
             * **/
            HashSet<int> get1 = UserRatedTen(intArray);
            foreach(int el in get1)
                Console.WriteLine($"the uers think the number{el} movies can reting 10");

        }

        //Get all movies rated 10 by 1 user at Least 
        //获得所有电影评级为10个用户至少
        static HashSet<int> UserRatedTen(int[,] intArray)
        {
            HashSet<int> resule = new HashSet<int>();
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i, j] == 10)
                    {
                        resule.Add(j);
                        Console.WriteLine(j);
                    }
                }
            }
            return resule;
        }

        static void FindGreatestNumberLocation(int[,] intArray)
        {
            int n = int.MinValue;
            int m = int.MinValue;
            int temp = int.MinValue;
            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                for(int j = 0; j < intArray.GetLength(1); j++)
                {
                    if (intArray[i,j]> temp)
                    {
                        n = i + 1;
                        m = j+1;
                    }
                }
            }
            Console.WriteLine($"the location of greatest in  a 2D array is {n} {m}");
        }

        static void CountLeter(string str)
        {

        }

        static bool ContainsAllEnglishLetters(string inputString)
        {
            HashSet<char> englishLetters = new HashSet<char>();
            foreach (char c in inputString.ToLower())
            {
                if (!englishLetters.Contains(c) && char.IsLetter(c))
                {
                    englishLetters.Add(c);
                }
                if (englishLetters.Count == 26)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
