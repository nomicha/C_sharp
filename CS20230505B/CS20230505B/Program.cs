using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CS20230505B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RN = new Random();
            int Nth;                       //每組第幾個樂透碼 N'th = 1,2,3,4,5,6,7
            int[] LottoCode = new int[8];  //LottoCode[1..7] , LottoCode[0]     雖然是要7個號，但是第0個數字要空下來，所以是8個數字
            bool test;    //flag    等等要用來判斷是否重複

            while (true)
            {
                try
                {

                    checked
                    {
                        Console.Write("請輸入需幾組樂透碼[6 + 1(特別號)]？Max.Numbe of Lotto[7 - 49]？Time for one code generated？");
                        string[] Lotto = Console.ReadLine().Split(' ');
                        int NUM = int.Parse(Lotto[0]);
                        int Max = int.Parse(Lotto[1]);
                        int OneCodeTime = int.Parse(Lotto[2]);

                        //if (NUM <= 0 || Max < 7 || Max > 49 || OneCodeTime <= 0) continue;
                        //if (NUM <= 0 || Max < 7 || Max > 49 || OneCodeTime <= 0) return;
                        if (NUM <= 0 || Max < 7 || Max > 49 || OneCodeTime <= 0) goto IMIB;  //等同於 continue
                        //上面的式子，如果把 IMIB (Label) 放在while迴圈外，效果等同於 return 

                        for (int n = 1; n <= NUM; n++)
                        {
                            Nth = 1;
                            while (Nth <= 7)
                            {
                                test = true;
                                while (test)
                                {
                                    test = false;
                                    LottoCode[Nth] = RN.Next(1, Max + 1);   //Lotto Number : 1~49
                                    System.Threading.Thread.Sleep(OneCodeTime);
                                    Console.Write(LottoCode[Nth]);

                                    
                                    for (int i = 1; i < Nth; i++)     //Array Scanning
                                    {
                                        if (LottoCode[Nth] == LottoCode[i])
                                        {
                                            Console.Write(string.Empty.PadLeft(2) );
                                            test = true;
                                            break;   //遇到重複的就斷迴圈
                                        }

                                    }
                                } //這個迴圈是用來處理重複數字的，所以不用加*
                                Console.Write("*  ");
                                Nth++;

                            }

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            for (int j = 1; j <= 7; j++)
                            {
                                Console.Write(LottoCode[j] + string.Empty.PadLeft(2));
                                //string.Empty.PadLeft(2) 的意思是填充兩個空白   也就是說寫法等同於 "  "
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine(); Console.WriteLine();

                        }

                        IMIB:;   //Label

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    //Console.WriteLine("Press any key try again!\n");
                    Console.ReadKey();
                }
            }
        }
    }
}
