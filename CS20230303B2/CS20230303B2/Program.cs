using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20230303B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    checked
                    {
                        int counter = 0;

                        //九宮格
                        //第0條件的n1~n9不重複，已沿用
                        for (int n1 = 1; n1 <= 9; n1++)
                        {
                            for (int n2 = 1; n2 <= 9; n2++)
                            {
                                if (n2 == n1) continue;
                                for (int n3 = 1; n3 <= 9; n3++)
                                {
                                    if (n3 == n1 || n3 == n2) continue;
                                    for (int n4 = 1; n4 <= 9; n4++)
                                    {
                                        if (n4 == n1 || n4 == n2 || n4 == n3) continue;
                                        for (int n5 = 1; n5 <= 9; n5++)
                                        {
                                            if (n5 != 5) continue;  //第6條件
                                            if (n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4) continue;
                                            for (int n6 = 1; n6 <= 9; n6++)
                                            {
                                                if (n6 == n1 || n6 == n2 || n6 == n3 || n6 == n4 || n6 == n5) continue;
                                                if (!PrimeYesNo(n4 * 100 + n5 * 10 + n6)) continue;  //第1條件
                                                //在fuction前面加一個 ! 代表說False
                                                for (int n7 = 1; n7 <= 9; n7++)
                                                {
                                                    if (n7 == n1 || n7 == n2 || n7 == n3 || n7 == n4 || n7 == n5 || n7 == n6) continue;
                                                    if (!PrimeYesNo(n1 * 100 + n4 * 10 + n7)) continue;  //第2條件
                                                    if (!PrimeYesNo(n3 * 100 + n5 * 10 + n7)) continue;  //第3條件
                                                    for (int n8 = 1; n8 <= 9; n8++)
                                                    {
                                                        if (n8 == n1 || n8 == n2 || n8 == n3 || n8 == n4 || n8 == n5 || n8 == n6 || n8 == n7) continue;
                                                        if ((n2 + n5 + n8) % 2 == 0) continue;  //第7條件
                                                        for (int n9 = 1; n9 <= 9; n9++)
                                                        {
                                                            if (!PrimeYesNo(n1 * 100 + n5 * 10 + n9)) continue;  //第4條件
                                                            if (!PrimeYesNo(n3 * 100 + n6 * 10 + n9)) continue;  //第5條件
                                                            if (n9 == n1 || n9 == n2 || n9 == n3 || n9 == n4 || n9 == n5 || n9 == n6 || n9 == n7 || n9 == n8) continue;

                                                            counter++;
                                                            Console.WriteLine(counter + ". ");
                                                            Console.WriteLine(n1 + " " + n2 + " " + n3);
                                                            Console.WriteLine(n4 + " " + n5 + " " + n6);
                                                            Console.WriteLine(n7 + " " + n8 + " " + n9);
                                                            Console.WriteLine();

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                        Console.WriteLine();
                        Console.WriteLine(counter + "組解");



                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    Console.WriteLine("Press any key try again!\n");
                    Console.ReadKey();

                }
            }
        }



        static bool PrimeYesNo(int X)
        {

            if (X <= 1) return false;
            else if (X == 2) return true;
            else if (X % 2 == 0) return false;
            else
            {
                //decimal SquareRoot = (int)Math.Pow(X, 0.5) + 1;
                decimal SquareRoot = (int)Math.Sqrt(X) + 1;    //Math.Sprt()是開根號，上面的也可
                //SquareRoot就是開根號的意思
                for (decimal i = 3; i < SquareRoot; i += 2)  //i += 2 就是 i = i + 2
                {
                    if (X % i == 0) return false;
                }
                return true;  //is prime number 是質數
            }

        }
    }
}
