using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20221021Bexam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int 國, 英, 數, 專一, 專二, 總;
            
            //  10/21
            Random RN = new Random();
            while (true) 
            {


                try
                {
                    Console.WriteLine("四技二專成績計算模擬[國文 英文 數學 專一 專二]");
                    Console.Write("請選擇[A]Input單人五科分數 [B]Input人數自動產生分數 [其他鍵]結束 ?");
                    string which = Console.ReadLine();
                    switch (which)
                    {
                        case "A":
                            //1.Display input parameters參數
                            Console.WriteLine("Input 國文？英文？數學？專一？專二？");

                            //2.string split 字串分割
                            string[] score = Console.ReadLine().Split(' ');

                            //3.Variables Declaration 變量聲明 & Assignment 賦值 & Data type Conversion 數據類型轉型
                            國 = int.Parse(score[0]);
                            英 = int.Parse(score[1]);
                            數 = int.Parse(score[2]);
                            專一 = int.Parse(score[3]);
                            專二 = int.Parse(score[4]);

                            //4.Computation 計算
                            總 = 國 + 英 + 數 + 專一 * 2 + 專二 * 2;

                            //5.Display Result
                            Console.WriteLine(國 + " + " + 英 + " + " + 數 + " + " + 專一 + "*2 + " + 專二 + "*2 = " + 總);
                            Console.WriteLine(國 + "[國文] + " + 英 + "[英文] + " + 數 + "[數學] + " + 專一 + "[專一]*2 + " + 專二 + "[專二]*2 = " + 總 + "[總分]");

                            break;
                        
                        //  10/21
                        case "B":
                            //1.Display input parameters參數
                            Console.WriteLine("考生人數？產生單筆資料速度(一秒 = 1000)？");

                            //2.string split 字串分割
                            //string[] score = Console.ReadLine().Split(' ');
                            string[] ltem = Console.ReadLine().Split(' ');
                            int N = int.Parse(ltem[0]);　//item[0]: 考生人數？
                            int Speed = int.Parse(ltem[1]);　　//item[1]: 產生單筆資料速度(一秒 = 1000)？

                            //for loop
                            //for (init初始值; condition條件式; increment增量值)
                            //{
                            //    statement(s);
                            //}
                            for (int i=1; i<=N; i++) 
                            {
                                //3.Variables Declaration 變量聲明 & Assignment 賦值 & Data type Conversion 數據類型轉型
                                國 = RN.Next(0, 101);
                                英 = RN.Next(0, 101);
                                數 = RN.Next(0, 101);
                                專一 = RN.Next(0, 101);
                                專二 = RN.Next(0, 101);

                                //4.Computation 計算
                                總 = 國 + 英 + 數 + 專一 * 2 + 專二 * 2;

                                //5.Display Result
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine(i + ". " + 國 + "[國文] + " + 英 + "[英文] + " + 數 + "[數學] + " + 專一 + "[專一]*2 + " + 專二 + "[專二]*2 = " + 總 + "[總分]\n");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;

                                //6.Thread.Sleep(？)
                                System.Threading.Thread.Sleep(Speed);
                            }

                            break;
                       
                        default:
                            return;

                    }
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
                    Console.ReadKey();
                }
            }
        }
    }
}
