using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20221007B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                double H = 0;
                double t = 0;
                double g = 9.80665;
                Random RN = new Random();    //2. 隨機

                try
                {
                    //1.
                    //Console.Write("Input 自由落體秒數(Second) =? ");
                    //t = double.Parse(Console.ReadLine());

                    //2.  隨機

                    Console.WriteLine(System.DateTime.Now);
                    t = 10 * RN.NextDouble();    //NextDouble是介於0.0~1.0(不含)的變數
                    Console.Write("Input 自由落體秒數(Second) =? " +Math.Round(t,1));

                    H = 1.0 / 2.0 * g * Math.Pow(t ,2);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(("\n      吊橋長度(H) = " + Math.Round(H, 2) + "公尺"));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(RN.Next(500 , 4001)); //讓休息時間介於0.5~4秒(含)
                    //System.Threading.Thread.Sleep(2000);     //停頓兩秒(這個Thread以後細說)
                }
                catch(Exception EX)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(EX);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.WriteLine("Try again!!\n");

                    //Console.ReadKey();
                }
            }
        }
    }
}
