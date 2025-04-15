using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS20230512B
{
    internal class Program
    {
        public struct STUDENT
        {
            public int S_No;
            public string ID;
            public string BT;    //BloodType
            public int BCC;
            public int CS;       //CSharp
            public int Total;

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
                            ST[n].S_No = n + 1;
                            
                            // 1. 原本就有的題目
                            ST[n].ID = (char)RN.Next(65, 91) + RN.Next(1, 3).ToString();
                            for (int i = 1; i <= 8; i++) ST[n].ID += RN.Next(0, 10);

                            // 2. 新稱的，血型題目
                            BloodType = RN.Next(0, 5);
                            if (BloodType == 0) ST[n].BT = "A";
                            else if (BloodType == 1) ST[n].BT = "B";
                            else if (BloodType == 2) ST[n].BT = "AB";
                            else ST[n].BT = "0";

                            ST[n].BCC = RN.Next(0, 101);
                            ST[n].CS = RN.Next(0, 101);
                            ST[n].Total = ST[n].BCC + ST[n].CS;

                        }
                        for (int i = 0; i < Number; i++)
                        {
                            Console.WriteLine(ST[i].S_No + ". " + ST[i].ID + "(" + ST[i].BT + ")：" + ST[i].BCC + " + " + ST[i].CS + " = " + ST[i].Total);
                        }
                        Console.WriteLine("==============================");
                        Console.Write("[1]總分低高排序與兩科均及格(或不及格)？ [2]依地區[身分證字號第1碼]與男女排序以及新竹縣市[H/O]男女人數統計？？");

                        int temp, F, M;
                        string str, Left, Right;

                        string[] Line = Console.ReadLine().Split(' ');
                        switch (Line[0])
                        {
                            case "1":
                                for (int i = 1; i < Number; i++)
                                {
                                    for (int j = 1; j <= Number - i; j++)
                                    {
                                        if (ST[j - 1].Total > ST[j].Total)
                                        {
                                            temp = ST[j].S_No;
                                            ST[j].S_No = ST[j - 1].S_No;
                                            ST[j - 1].S_No = temp;

                                            str = ST[j].ID;
                                            ST[j].ID = ST[j - 1].ID;
                                            ST[j - 1].ID = str;

                                            str = ST[j].BT;
                                            ST[j].BT = ST[j - 1].BT;
                                            ST[j - 1].BT = str;

                                            temp = ST[j].BCC;
                                            ST[j].BCC = ST[j - 1].BCC;
                                            ST[j - 1].BCC = temp;

                                            temp = ST[j].CS;
                                            ST[j].CS = ST[j - 1].CS;
                                            ST[j - 1].CS = temp;

                                            temp = ST[j].Total;
                                            ST[j].Total = ST[j - 1].Total;
                                            ST[j - 1].Total = temp;
                                        }
                                    }
                                }
                                for (int i = 0; i < Number; i++)
                                {
                                    Console.Write(ST[i].S_No + ". " + ST[i].ID + "(" + ST[i].BT + ")：");

                                    if (ST[i].BCC < 60 && ST[i].CS < 60) Console.ForegroundColor= ConsoleColor.Red;
                                    if (ST[i].BCC >= 60 && ST[i].CS >= 60) Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(ST[i].BCC + " + " + ST[i].CS);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(" = " + ST[i].Total);

                                }

                                break;

                            case "2":
                                for (int i = 1; i < Number; i++)
                                {
                                    for (int j = 1; j <= Number - i; j++)
                                    {
                                        Left = ST[j - 1].ID.Substring(0, 1);
                                        Right = ST[j].ID.Substring(0, 1);
                                        if (string.Compare(Left, Right) < 0)  //當左邊小於右邊  //這個迴圈是倒過來的，因為等等反著數
                                        {
                                            temp = ST[j].S_No;
                                            ST[j].S_No = ST[j - 1].S_No;
                                            ST[j - 1].S_No = temp;

                                            str = ST[j].ID;
                                            ST[j].ID = ST[j - 1].ID;
                                            ST[j - 1].ID = str;

                                            str = ST[j].BT;
                                            ST[j].BT = ST[j - 1].BT;
                                            ST[j - 1].BT = str;

                                            temp = ST[j].BCC;
                                            ST[j].BCC = ST[j - 1].BCC;
                                            ST[j - 1].BCC = temp;

                                            temp = ST[j].CS;
                                            ST[j].CS = ST[j - 1].CS;
                                            ST[j - 1].CS = temp;

                                            temp = ST[j].Total;
                                            ST[j].Total = ST[j - 1].Total;
                                            ST[j - 1].Total = temp;
                                        }
                                        else if (string.Compare(Left, Right) == 0)
                                        {
                                            if (string.Compare(ST[j - 1].ID.Substring(1, 1), ST[j].ID.Substring(1, 1)) < 0)
                                            {
                                                temp = ST[j].S_No;
                                                ST[j].S_No = ST[j - 1].S_No;
                                                ST[j - 1].S_No = temp;

                                                str = ST[j].ID;
                                                ST[j].ID = ST[j - 1].ID;
                                                ST[j - 1].ID = str;

                                                str = ST[j].BT;
                                                ST[j].BT = ST[j - 1].BT;
                                                ST[j - 1].BT = str;

                                                temp = ST[j].BCC;
                                                ST[j].BCC = ST[j - 1].BCC;
                                                ST[j - 1].BCC = temp;

                                                temp = ST[j].CS;
                                                ST[j].CS = ST[j - 1].CS;
                                                ST[j - 1].CS = temp;

                                                temp = ST[j].Total;
                                                ST[j].Total = ST[j - 1].Total;
                                                ST[j - 1].Total = temp;
                                            }
                                        }
                                    }

                                }

                                for (int i = Number - 1; i >= 0; i--)
                                {
                                    Console.WriteLine(ST[i].S_No + ". " + ST[i].ID + "(" + ST[i].BT + ")：" + ST[i].BCC + " + " + ST[i].CS + " = " + ST[i].Total);
                                }

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
