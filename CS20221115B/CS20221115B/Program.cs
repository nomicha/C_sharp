using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20221115B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\n\n" + System.DateTime.Now);
                    Console.Write("[A]Factorial[？？]  [B]Fibonacci[？？]  [C]Prime Number[？]  [D]GCD[LCM] = (Input Number：？？)");
                    string[] li = Console.ReadLine().Split(' ');
                    if (li[0] == "") break;
                    string which = li[0];
                    int start, last, temp;
                     checked
                    {
                        switch (which)
                        {
                            case "A":
                                //int FACT;
                                decimal FACT;
                                start = int.Parse(li[1]);
                                last = int.Parse(li[2]);
                                if (start > last)   //Exchange the value of two Variables 交換兩個變量的數值
                                {
                                    temp = start;  //用temp當start和last中間的跳台
                                    start = last;
                                    last = temp;
                                }
                                for (int n = start; n <= last; n++)
                                {
                                    if (n < 0) Console.WriteLine(n + "!數值 >= 0");
                                    else if (n == 0 || n == 1) Console.WriteLine(n + "! = 1");
                                    else
                                    {
                                        FACT = 1;
                                        for (int i = n; i > 0; i--)
                                        {
                                            FACT = FACT * i;  //FACT *= i;
                                        }
                                        Console.WriteLine(n + "!= " + FACT);
                                    }
                                }
                                break;

                            case "B":

                                break;

                            case "C":

                                break;

                            case "D":

                                break;

                            default:
                                return; //break;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                finally
                {
                    Console.WriteLine("Press any key to Exit");
                    Console.ReadKey();
                }
            }
        }
    }
}
