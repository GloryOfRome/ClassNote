using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace 钢琴曲
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                ConsoleKeyInfo ck = Console.ReadKey(true);
                char c = ck.KeyChar;
                Console.WriteLine(c);
                //Console.WriteLine(ck.KeyChar);
                WindowsMediaPlayer wm = new WindowsMediaPlayer();
                wm.URL = @"E:\video\" + c + ".mp3";

                //Console.Beep(800, 500);
            }
        }
    }
}
