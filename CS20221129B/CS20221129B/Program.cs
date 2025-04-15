﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20221129B
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
                                // 11/15
                                //Factorial階層概念:https://en.wikipedia.org/wiki/Factorial
                                //Flow Chart流程圖:
                                //https://www.rff.com/n_factorial_flowchart.php
                                //https://www.softwareideas.net/a/1583/Factorial-of-a-Number--Flowchart
                                //https://kishanjadav00.files.wordpress.com/2016/09/flowchartfact.jpg
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
                                //1.Nested Loop 嵌套循環
                                //for (int n = start; n <= last; n++)
                                //{
                                //    if (n < 0) Console.WriteLine(n + "!數值 >= 0");
                                //    else if (n == 0 || n == 1) Console.WriteLine(n + "! = 1");
                                //    else
                                //    {
                                //        FACT = 1;
                                //1. for Loop 的 Decrease遞減
                                //for (int i = n; i > 0; i--)
                                //{
                                //    FACT = FACT * i;  //或者是FACT *= i;
                                //}
                                //Console.WriteLine(n + "!= " + FACT);

                                // 11/25
                                //4. while Loop Decrease
                                //int i = n;
                                //while (i > 0 )
                                //{
                                //    FACT *= i;
                                //    i--;
                                //}

                                //2. for Loop 的 Increase遞增
                                //for (int i = 1; i <= n; i++)  //記住條件式要是i <= n
                                //{
                                //    FACT = FACT * i;
                                //}

                                //3. while Loop Increase
                                //int i = 1;
                                //while(i <= n)
                                //{
                                //    FACT *= i;
                                //    i++;
                                //}



                                //Console.WriteLine(n + "!= " + FACT);
                                //}

                                // 11/29
                                //2. Method方法 / Function功能 / SubRoutine子程序  ---> 用公式解階層
                                //F(X,Y) = X^2 + X*Y +Y^2
                                //F(2,3) = 19

                                for (int n = start; n <= last; n++)
                                {
                                    if (Factorial(n) == -1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(n + "！= " + "N!之值須 >= 0");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else Console.WriteLine(n + "！= " + Factorial(n));
                                }

                                break;

                            case "B":
                                //Fibonacci:https://en.wikipedia.org/wiki/Fibonacci_number
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
                                    if (Fibonacci(n) == -1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Fib( " + n + " )= " + "Fib(n)之n >= 0");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else Console.WriteLine("Fib( " + n + " )= " + Fibonacci(n) );
                                }




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
        }   //Main

        static decimal Factorial(int X)   //要return一個值，不然Factorial會有錯誤
        {
            if (X < 0) return -1;
            else if (X == 0 || X == 1) return 1;
            else  // X > 1 的情況
            {
                decimal F = 1;
                for (int i = X; i > 0; i--)
                {
                    F = F * i;  //F *= i;
                }
                return F;
            }
        }

        static decimal Fibonacci(int X)
        {
            if (X < 0) return -1;
            else if (X == 0) return 0;
            else if (X == 1) return 1;
            else  //X >= 2
            {
                decimal F0 = 0;
                decimal F1 = 1;
                decimal Fn = 0;

                int f = 2;
                while (f <= 0)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                    f++;
                }

                //下面是我寫的
                //for (int f = X; f > 0; f--)
                //{
                //    Fn = F0 + F1;
                //    F0 = F1;
                //    F1 = Fn;
                //}

                return Fn;
            }
        }
    }
}
