using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CS20230303B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    checked
                    {
                        int counter =0;
                        //0303
                        //今天繼續九宮格
                        for (int n1 = 1; n1 <= 9; n1++)
                        {
                            for (int n2 = 1; n2 <= 9; n2++)
                            {
                                if (n2 == n1) continue;
                                for (int n3 = 1; n3 <= 9; n3++)
                                {
                                    if (n3 == n1 || n3 == n2) continue;
                                    if (n1 + n2 + n3 != 15) continue; // !=是不等於  //橫向
                                    //上面這行一定要在n3下弄
                                    for (int n4 = 1; n4 <= 9; n4++)
                                    {
                                        if (n4 == n1 || n4 == n2 || n4 == n3) continue;
                                        for(int n5 = 1; n5 <= 9; n5++)
                                        {
                                            if (n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4) continue;
                                            for (int n6 = 1; n6 <= 9; n6++)
                                            {
                                                if (n6 == n1 || n6 == n2 || n6 == n3 || n6 == n4 || n6 == n5) continue;
                                                if (n4 + n5 + n6 != 15) continue; //橫向
                                                //上面這行一定要在n6下弄
                                                for (int n7 = 1; n7 <= 9; n7++)
                                                {
                                                    if (n7 == n1 || n7 == n2 || n7 == n3 || n7 == n4 || n7 == n5 || n7 == n6) continue;
                                                    if (n1 + n4 + n7 != 15) continue; //縱向
                                                    if (n3 + n5 + n7 != 15) continue;//斜向
                                                    for (int n8 = 1; n8 <= 9; n8++)
                                                    {
                                                        if (n8 == n1 || n8 == n2 || n8 == n3 || n8 == n4 || n8 == n5 || n8 == n6 || n8 == n7) continue;
                                                        if (n2 + n5 + n8 != 15) continue; //縱向
                                                        for (int n9 = 1; n9 <= 9; n9++)
                                                        {
                                                            if (n9 == n1 || n9 == n2 || n9 == n3 || n9 == n4 || n9 == n5 || n9 == n6 || n9 == n7 || n9 == n8) continue;
                                                            //if (n7 + n8 + n9 != 15) continue;  //橫向  //但不需要
                                                            //if (n3 + n6 + n9 != 15) continue;  //縱向  //但不需要
                                                            if (n1 + n5 + n9 != 15) continue;  //斜向
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
                catch(Exception ex)
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
