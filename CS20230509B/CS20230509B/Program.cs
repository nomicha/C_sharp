using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS20230509B
{
    internal class Program
    {
        //static System.Threading.Thread threadA, threadB, threadC;  
        //不用System.Threading，因為最上面已經有using System.Threading;
        static Thread threadA, threadB, threadC;
        static Random RN = new Random();
        static int A, B, C;
        static int Nth, DelayTime;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Press Y(y) for Continue Else for No？ Nth？ Max. Delay Time(ms)？");
                    string[]YN = Console.ReadLine().Split(' ');
                    Nth = int.Parse(YN[1]);
                    DelayTime = int.Parse(YN[2]);
                    if (YN[0] == "Y" || YN[0] == "y" || Nth < 1)
                    {
                        A = 0; B = 0; C = 0;

                        threadA = new System.Threading.Thread(new System.Threading.ThreadStart(IMA));
                        threadB = new Thread(new ThreadStart(IMB));  //System.Threading.一樣可省略
                        threadC = new Thread(new ThreadStart(IMC));

                        threadA.Start();threadB.Start();threadC.Start();
                    }
                    else return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Console.WriteLine("Press any key try again!\n");
                    Console.ReadKey();
                }
            }
        }

        private static void IMA()
        {
            while(true)
            {
                Thread.Sleep(RN.Next(10, DelayTime));
                A++;
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("資一甲(" + A +  ")：" + System.DateTime.Now);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                if (A == Nth)
                {
                    threadB.Abort(); threadC.Abort();   //Abort就是停止，先把另外兩個thread停掉
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Winner：資一甲");  //宣告勝利後
                    Console.ForegroundColor = ConsoleColor.White;
                    threadA.Abort();  //再把自己關了
                }
            }
        }
        private static void IMB()
        {
            while (true)
            {
                Thread.Sleep(RN.Next(10, DelayTime));
                B++;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("資一乙(" + B + ")：" + DateTime.Now.ToLongDateString());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                if (B == Nth)
                {
                    threadA.Abort(); threadC.Abort();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Winner：資一乙");
                    Console.ForegroundColor = ConsoleColor.White;
                    threadB.Abort();
                }
            }
        }
        private static void IMC()
        {
            while (true)
            {
                Thread.Sleep(RN.Next(10, DelayTime));
                C++;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("資一丙(" + C + ")：" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                if (C == Nth)
                {
                    threadA.Abort(); threadB.Abort();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Winner：資一丙");
                    Console.ForegroundColor = ConsoleColor.White;
                    threadC.Abort();
                }
            }
        }

    }
}
