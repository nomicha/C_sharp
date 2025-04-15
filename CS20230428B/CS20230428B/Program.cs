using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20230428B
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RN = new Random();
            Eratosthenes PN = new Eratosthenes();  //新形成的物件叫做PN
            PN.Create();

            while (true)
            {
                try
                {
                    Console.WriteLine("\n\n" + System.DateTime.Now);
                    Console.Write("[A]How many prime numbers[？？]  [B]Prime Number[？]  [E]Eratostosnes[？]");
                    string[] Line = Console.ReadLine().Split(' ');
                    if (Line[0] == "") return;
                    string which = Line[0];                   
                    double StartTime, EndTime;
                    checked
                    {
                        switch (which)
                        {                           
                            
                            case "A":
                                Console.WriteLine("Prime Number？？(Between two Number)1 7919");
                                Console.WriteLine("Prime Number？？(Between two Number)2147400000 2147483646");
                                Console.WriteLine("Prime Number？？(Between two Number)2140000000 2147483646");
                                string[] TWO = Console.ReadLine().Split(' ');    
                                if (TWO[0] == "") break;
                                long X = long.Parse(TWO[0]);         
                                long Y = long.Parse(TWO[1]);

                                StartTime = System.DateTime.Now.TimeOfDay.TotalSeconds;
                                int no = 0;   //number of prime number                      
                                for (long i = X; i <= Y; i++) 
                                {
                                    //if ( PrimeYesNo(i) ) //耗時長
                                    //if ( PrimeYN(i) )
                                    if ( PN.Test(i) )
                                    {
                                        no++;
                                        Console.WriteLine("P" + no + "= " + i);                                       
                                    }
                                }
                                EndTime = DateTime.Now.TimeOfDay.TotalSeconds;
                                Console.WriteLine("兩數間共 " + no + " 個質數；計時：" + Math.Round(EndTime - StartTime, 3) + " 秒");
                                break;

                            case "B":
                                decimal nth = 0;   //nth prime number
                                decimal NN = 0;    //Natural Number
                                decimal Number = int.Parse(Line[1]);    // number of prime Number
                                
                                StartTime = System.DateTime.Now.TimeOfDay.TotalSeconds;
                                while (nth < Number)
                                {
                                    if ( PrimeYesNo(NN) )
                                    //if ( PrimeYN((int)NN)  ) 
                                    {
                                        nth++;
                                        Console.WriteLine("P" + nth + "= " + NN);
                                    }
                                    NN++;
                                }
                                EndTime = DateTime.Now.TimeOfDay.TotalSeconds;
                                Console.WriteLine("計算 " + Number + "個質數計：" + Math.Round(EndTime-StartTime, 3) + " 秒");
                                break;

                            case "E":
                                StartTime = System.DateTime.Now.TimeOfDay.TotalSeconds;
                                

                                EndTime = DateTime.Now.TimeOfDay.TotalSeconds;
                                //Console.WriteLine("計算 " + number + "個質數計：" + Math.Round(EndTime - StartTime, 3) + " 秒");
                                break;

                            



                            default:
                                return; //break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.WriteLine("Press any key for Continue(Exit)");
                    //Console.ReadKey();
                }
            }
        }

        static bool PrimeYesNo(decimal X)
        {
           
            if (X <= 1) return false;
            else if (X == 2) return true;
            else if (X % 2 == 0) return false;
            else   //X > 2
            {              
                for (decimal i = 3; i * i <= X; i += 2)
                {
                    if (X % i == 0) return false;
                }
                return true; // is prime Number
            }
        }
        static bool PrimeYN(double X)
        {           
            if (X <= 1) return false;
            else if (X == 2) return true;
            else if (X % 2 == 0) return false;
            else   //X > 2
            {               
                int SquareRoot = (int)Math.Sqrt( (double)X ) + 1;  //先定義開根號，讓等等跑迴圈的時候可以節省時間
                
                for (int i = 3; i <= SquareRoot ; i += 2)
                {
                    if (X % i == 0) return false;
                }
                return true; // is prime Number
            }
        }        
    }

}
