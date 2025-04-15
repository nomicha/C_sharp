using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20221216B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RN = new Random(); //在while迴圈外定義RN是怕重複定義太多次
            while (true)
            {
                try
                {
                    Console.WriteLine("\n\n" + System.DateTime.Now);
                    Console.WriteLine("[A]Factorial[？？]  [B]Fibonacci[？？]  [C]Prime Number[？]  [D]GCD&LCM[？？] [E]EvenOdd");
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
                                    else
                                    {
                                        // 12/6
                                        if (Fibonacci(n) % 2 == 0 ) Console.WriteLine("Fib( " + n + " )= " + Fibonacci(n) + "[偶]");
                                        else Console.WriteLine("Fib( " + n + " )= " + Fibonacci(n) + "(奇)");
                                    } 

                                }

                                break;

                            case "C":
                                // 12/6
                                //Prime number:https://zh.wikipedia.org/wiki/%E8%B4%A8%E6%95%B0
                                decimal nth = 0; //nth prime number 第幾個
                                decimal NN = 0;  //Natural number 自然數
                                decimal number = int.Parse(li[1]);  //number of prime number  要幾個
                                double StartTime, EndTime;
                                StartTime = DateTime.Now.TimeOfDay.TotalSeconds;
                                while(nth < number)
                                {
                                    if (PrimeYesNo(NN))
                                    {
                                        nth++;
                                        Console.WriteLine("P" + nth + "= " + NN);
                                    }
                                    NN++; //判定完第一個就可以開始下一個
                                }
                                EndTime = DateTime.Now.TimeOfDay.TotalSeconds;
                                Console.WriteLine("計算 " + number + "個質數計: " + Math.Round(EndTime - StartTime, 3));

                                break;

                            case "D":
                                // 12/9 最大公因數[GCD]和最小公倍數[LCM]
                                decimal X = decimal.Parse(li[1]);
                                decimal Y = decimal.Parse(li[2]);
                                Console.Write("GCD(" + X + "," + Y + ")= " + GCD(X, Y));
                                Console.Write("LCM(" + X + "," + Y + ")= " + LCM(X, Y));
                                break;

                            // 12/16 EvenOdd
                            case "E":
                                Console.WriteLine( EvenOdd(RN.Next(1000000000,int.MaxValue)) );
                                //範圍從十位數最小到int的最大值
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
                while (f <= X)
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

        // 12/6
        static bool PrimeYesNo(decimal X)  //開始判別是不是質數
        {
            //1.Definition  下面這個程式很慢
            //if ( X <= 1) return false;
            //else  // X > 1
            //{

            //    for (decimal i = 2; i < X; i++) //X % [2, X-1] 
            //    {
            //        if (X % i == 0) return false;  //如果從2到X-1都沒有false(被整除)，就會被視為true(質數)
            //    }
            //    return true;  //is prime number 是質數

            //2.Exclude Even number 排除偶數的作法
            //if (X <= 1) return false;
            //else if (X == 2) return true;
            //else if (X % 2 == 0)return false;
            //else 
            //{
            //    for (decimal i = 3; i < X; i += 2)  //i += 2 就是 i = i + 2
            //    {
            //        if (X % i == 0) return false;  
            //    }
            //    return true;  //is prime number 是質數
            //}

            // 12/9
            //3.Exclude Sprt((double)X) to X-1  讓範圍縮小到 X變成1/2次方
            if (X <= 1) return false;
            else if (X == 2) return true;
            else if (X % 2 == 0) return false;
            else
            {
                decimal SquareRoot = (decimal)Math.Pow((double)X,0.5) + 1;  
                //SquareRoot就是開根號的意思
                for (decimal i = 3; i < SquareRoot; i += 2)  //i += 2 就是 i = i + 2
                {
                    if (X % i == 0) return false;
                }
                return true;  //is prime number 是質數
            }

        }
        
        // 12/9
        static decimal GCD(decimal X,decimal Y)  //X,Y:Formal Parameter 形式參數
        {
            if (X < 0) X = -X;
            if (Y < 0) Y = -Y;

            decimal R;
            while(X%Y != 0)
            {
                R = X % Y;
                X = Y;
                Y = R; 
            }
            return Y;
        }

        static decimal LCM(decimal X, decimal Y)
        {
            //下面只是暫時放著
            X = 0;
            Y = 0;
            return X;
        }
        
        // 12/16
        static string EvenOdd(int X)
        {
            string result = X.ToString();  //把結果保留成字串
            int even = 0;
            int odd = 0;
            while(X != 0) //當X不等於0時候，執行迴圈
            {
                if(X % 2 == 0) even++;
                else odd++;
                X = X / 10;
            }
            return result + "：偶(" + even + ")奇(" + odd +")";
        }
    }
}
