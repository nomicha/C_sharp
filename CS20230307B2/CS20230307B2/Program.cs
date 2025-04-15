using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20230307B2
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
                                            if (n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4) continue;
                                            if ((n1 * 10 + n2) * n3 != (n4 * 10 + n5)) continue;  //條件1
                                            for (int n6 = 1; n6 <= 9; n6++)
                                            {
                                                if (n6 == n1 || n6 == n2 || n6 == n3 || n6 == n4 || n6 == n5) continue;
                                                for (int n7 = 1; n7 <= 9; n7++)
                                                {
                                                    if (n7 == n1 || n7 == n2 || n7 == n3 || n7 == n4 || n7 == n5 || n7 == n6) continue;
                                                    for (int n8 = 1; n8 <= 9; n8++)
                                                    {
                                                        if (n8 == n1 || n8 == n2 || n8 == n3 || n8 == n4 || n8 == n5 || n8 == n6 || n8 == n7) continue;
                                                        for (int n9 = 1; n9 <= 9; n9++)
                                                        {
                                                            if (n9 == n1 || n9 == n2 || n9 == n3 || n9 == n4 || n9 == n5 || n9 == n6 || n9 == n7 || n9 == n8) continue;
                                                            if ((n4 * 10 + n5) + (n6 * 10 + n7) != (n8 * 10 + n9) ) continue;  //條件2

                                                            counter++;
                                                            Console.WriteLine(counter + ". ");
                                                            Console.WriteLine(" " + n1 + "" + n2 + "\nx " + n3 + "\n----");
                                                            Console.WriteLine(" " + n4 + "" + n5 + "\n+" + n6 + "" + n7 + "\n----");
                                                            Console.WriteLine(" " + n8 + "" + n9);
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


    }
}
