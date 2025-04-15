using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20221004B2  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //世界上12座壯觀
            //https://digiphoto.techbang.com/posts/7295-worlds-12-most-spectacular-footbridges
            //自由落體 //重力加速度
            //標準重力加速度是9.80665m/s^2
            //Algorithm 重力加速度: H = 1/2 * g * t^2

            while (true) 
            {
                double H = 0;
                double t = 0;
                double g = 9.80665;
                try
                {
                    Console.WriteLine("輸入 自由落體之秒數(Second)=? ");
                    t = double.Parse(Console.ReadLine());   
                    H = 1.0 / 2.0 * g * Math.Pow(t, 2);
                    Console.WriteLine("    吊橋高度(H)= " + Math.Round(H, 2) + "公尺");

                }
                catch(Exception EX)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(EX);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally 
                {
                    Console.WriteLine("\n~Press any key for continue~\n");
                    Console.ReadKey();
                }
            }
        }
    }
}
