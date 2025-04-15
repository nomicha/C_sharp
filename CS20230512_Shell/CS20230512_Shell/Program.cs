using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20230512_Shell
{
    internal class Program
    {
        public struct STUDENT
        {
           
        }
        static void Main(string[] args)
        {
            Random RN = new Random();

            while (true)
            {
                try
                {
                    checked
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n程式碼中限制僅能使用一個陣列");
                        Console.WriteLine("身分證字號第1碼[A(65)~Z(90)]；第2碼[1男2女]；第3~10碼[數字]；(血型[A,B,O,AB])");                        
                        Console.WriteLine("學號：計算機概論 + 程式設計 = 總分");
                        Console.Write("Number of ID？[1,1000]");
                        int Number = int.Parse(Console.ReadLine());
                        STUDENT[] ST = new STUDENT[Number];
                        Console.ForegroundColor = ConsoleColor.White;

                        int BloodType;
                        for (int n = 0; n < Number; n++)
                        {
                            
                        }
                        for (int i = 0; i < Number; i++)
                        {
                            //Console.WriteLine(ST[i].S_No + ". " + ST[i].ID + "(" + ST[i].BT + ")：" + ST[i].BCC + " + " + ST[i].CS + " = " + ST[i].Total);
                        }
                        Console.WriteLine("==============================");
                        Console.Write("[1]總分低高排序與兩科均及格(或不及格)？ [2]依地區[身分證字號第1碼]與男女排序以及新竹縣市[H/O]男女人數統計？？");

                        int temp, F, M;
                        string str, Left, Right;

                        string[] Line = Console.ReadLine().Split(' ');
                        switch (Line[0])
                        {
                            case "1":
                               

                                break;

                            case "2":
                               
                                break;

                            default:
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    //Console.WriteLine(ex.Message);
                }
                finally
                {
                    //Console.ReadKey();
                }
            }
        }
    }
}
