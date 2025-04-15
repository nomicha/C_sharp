using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20230328B
{
    internal class Program
    {
        struct STUDENT      // 4/18主題: 定義一個可以用來混用資料型態的串列
        {
            public int S_No;
            public string Name;
            public int BCC;
            public int CSharp;
            public int DS;
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
                        Console.Write("\r\n僅限使用單一個一維陣列\r\nINPUT number of Student？ Max. Length of Last Name？");
                        string[] Line = Console.ReadLine().Split(' ');
                        int number = int.Parse(Line[0]);
                        int namelength = int.Parse(Line[1]);
                        string Name;
                        //char Name;
                        int BCC, CSharp, DS, Total;

                        //string[] ST = new string[number];  
                        STUDENT[] ST = new STUDENT[number];   // 4/18 
                        Console.WriteLine("序號. 姓名：計概 + C# + 資料結構 = 總分");
                        for (int n =1; n <= number; n++)
                        {
                            ST[n - 1].S_No= n;
                            ST[n - 1].Name = ((char)RN.Next(65, 91)).ToString();  //The first Capital 大寫部分  //ASCII
                            //前面放char是為了改變字元
                            for (int j = 1; j <= RN.Next(1, namelength); j++)  
                            {
                                ST[n - 1].Name += ((char)RN.Next(97, 123)).ToString();  //小寫部分
                            }
                            ST[n - 1].BCC = RN.Next(0, 101);
                            ST[n - 1].CSharp = RN.Next(0, 101);
                            ST[n - 1].DS = RN.Next(0, 101);
                            ST[n - 1].Total = ST[n - 1].BCC +ST[n - 1].CSharp + ST[n - 1].DS;

                            //Console.WriteLine(ST[n - 1]       //不需要了，跟原本另一行併合
                            Console.WriteLine(ST[n - 1].S_No + ". " + ST[n - 1].Name + "：" + ST[n - 1].BCC + "+" + ST[n - 1].CSharp + "+" + ST[n - 1].DS + " = " + ST[n - 1].Total);
                        }
                        int temp,Left, Right;
                        int pos1, pos2, pos3, pos4; //pos:position 
                        string F, S;  // First, Second
                        string str;
                        Console.Write("======================================================\r\nSorting by Score(Descending)|Name(Ascending)|SN|[4]平均分數與資料結構皆及格？");
                        string[] which = Console.ReadLine().Split(' ');
                        switch (which[0])
                        {
                            case "S":
                                for (int i = 1; i < number; i++)  //氣泡比較法回合數
                                {
                                    for (int j = 1; j <= number - i; j++)  // 比較次數
                                    {

                                        if (ST[j - 1].Total > ST[j].Total)      //Swap ST[j - 1]     ST[j]
                                        {
                                            temp = ST[j - 1].Total;
                                            ST[j - 1].Total = ST[j].Total;
                                            ST[j].Total = temp;

                                            temp = ST[j - 1].S_No;
                                            ST[j - 1].S_No = ST[j].S_No;
                                            ST[j].S_No = temp;

                                            str = ST[j - 1].Name;
                                            ST[j - 1].Name = ST[j].Name;
                                            ST[j].Name = str;

                                            temp = ST[j - 1].BCC;
                                            ST[j - 1].S_No = ST[j].BCC;
                                            ST[j].BCC = temp;

                                            temp = ST[j - 1].CSharp;
                                            ST[j - 1].CSharp = ST[j].CSharp;
                                            ST[j].CSharp = temp;

                                            temp = ST[j - 1].DS;
                                            ST[j - 1].DS = ST[j].DS;
                                            ST[j].DS = temp;
                                        }

                                        //Left = int.Parse(ST[j - 1].Substring(ST[j - 1].IndexOf("=") + 2));  //Substring是為了抓數值
                                        //Right = int.Parse(ST[j].Substring(ST[j].IndexOf("=") + 2));  
                                        ////IndexOf是用來定位，而其後面的+2就是為了抓"="後的第2位數值 (因為中間有空格，所以是第2位)
                                        //if (Left > Right)  //Swap ST[j - 1]  ST[j]
                                        //{
                                        //    str = ST[j - 1];
                                        //    ST[j - 1] = ST[j];
                                        //    ST[j] = str;
                                        //}
                                    }
                                }
                                for (int k = number - 1; k >= 0; k--)   //Descending:由大到小   /此迴圈用來重新排序
                                {
                                    //Console.WriteLine(ST[k]);
                                    Console.WriteLine(ST[k].S_No + ". " + ST[k].Name + "：" + ST[k].BCC + "+" + ST[k].CSharp + "+" + ST[k].DS + " = " + ST[k].Total);
                                }

                                break;

                            case "N":
                                for (int i = 1; i < number; i++)  // nth Round 氣泡比較法回合數
                                {
                                    for (int j = 1; j <= number - i; j++)  // nth Round Comparison Times 比較次數
                                    {
                                        if (String.Compare(ST[j - 1].Name , ST[j].Name) > 0 )      //Swap ST[j - 1]     ST[j]
                                        {
                                            temp = ST[j - 1].Total;
                                            ST[j - 1].Total = ST[j].Total;
                                            ST[j].Total = temp;

                                            temp = ST[j - 1].S_No;
                                            ST[j - 1].S_No = ST[j].S_No;
                                            ST[j].S_No = temp;

                                            str = ST[j - 1].Name;
                                            ST[j - 1].Name = ST[j].Name;
                                            ST[j].Name = str;

                                            temp = ST[j - 1].BCC;
                                            ST[j - 1].S_No = ST[j].BCC;
                                            ST[j].BCC = temp;

                                            temp = ST[j - 1].CSharp;
                                            ST[j - 1].CSharp = ST[j].CSharp;
                                            ST[j].CSharp = temp;

                                            temp = ST[j - 1].DS;
                                            ST[j - 1].DS = ST[j].DS;
                                            ST[j].DS = temp;
                                        }

                                        //pos1 = ST[j - 1].IndexOf(". ");
                                        //pos2 = ST[j - 1].IndexOf("：");
                                        //F = ST[j - 1].Substring(pos1 + 2, pos2 - (pos1+2));

                                        //pos3 = ST[j].IndexOf(". ");
                                        //pos4 = ST[j].IndexOf("：");
                                        //S = ST[j].Substring(pos3 + 2, pos4 - (pos3+2));

                                        //if (String.Compare(F,S) > 0)  // F > S
                                        //{
                                        //    str = ST[j - 1];
                                        //    ST[j - 1] = ST[j];
                                        //    ST[j] = str;
                                        //}
                                    }
                                }
                                for (int k = 0; k <= number - 1; k++)   //Ascending:由小到大  
                                {
                                    Console.WriteLine(ST[k].S_No + ". " + ST[k].Name + "：" + ST[k].BCC + "+" + ST[k].CSharp + "+" + ST[k].DS + " = " + ST[k].Total);
                                }

                                break;
                            
                            case "SN":    //先用分數排序由大到小，而遇到分數相同的，再用名字由A到Z
                                for (int i = 1; i < number; i++)  //這邊先把case "S" 的複製
                                {
                                    for (int j = 1; j <= number - i; j++)  
                                    {

                                        if (ST[j - 1].Total > ST[j].Total)      //Swap ST[j - 1]     ST[j]
                                        {
                                            temp = ST[j - 1].Total;
                                            ST[j - 1].Total = ST[j].Total;
                                            ST[j].Total = temp;

                                            temp = ST[j - 1].S_No;
                                            ST[j - 1].S_No = ST[j].S_No;
                                            ST[j].S_No = temp;

                                            str = ST[j - 1].Name;
                                            ST[j - 1].Name = ST[j].Name;
                                            ST[j].Name = str;

                                            temp = ST[j - 1].BCC;
                                            ST[j - 1].S_No = ST[j].BCC;
                                            ST[j].BCC = temp;

                                            temp = ST[j - 1].CSharp;
                                            ST[j - 1].CSharp = ST[j].CSharp;
                                            ST[j].CSharp = temp;

                                            temp = ST[j - 1].DS;
                                            ST[j - 1].DS = ST[j].DS;
                                            ST[j].DS = temp;
                                        }
                                        else if (ST[j - 1].Total == ST[j].Total)
                                        {
                                            if (String.Compare(ST[j - 1].Name, ST[j].Name) < 0)      //這邊要相反，因為等等排序是由大到小
                                            {
                                                temp = ST[j - 1].Total;
                                                ST[j - 1].Total = ST[j].Total;
                                                ST[j].Total = temp;

                                                temp = ST[j - 1].S_No;
                                                ST[j - 1].S_No = ST[j].S_No;
                                                ST[j].S_No = temp;

                                                str = ST[j - 1].Name;
                                                ST[j - 1].Name = ST[j].Name;
                                                ST[j].Name = str;

                                                temp = ST[j - 1].BCC;
                                                ST[j - 1].S_No = ST[j].BCC;
                                                ST[j].BCC = temp;

                                                temp = ST[j - 1].CSharp;
                                                ST[j - 1].CSharp = ST[j].CSharp;
                                                ST[j].CSharp = temp;

                                                temp = ST[j - 1].DS;
                                                ST[j - 1].DS = ST[j].DS;
                                                ST[j].DS = temp;
                                            }
                                        }


                                        //Left = int.Parse(ST[j - 1].Substring(ST[j - 1].IndexOf("=") + 2));  
                                        //Right = int.Parse(ST[j].Substring(ST[j].IndexOf("=") + 2));
                                        //if (Left > Right)  
                                        //{
                                        //    str = ST[j - 1];
                                        //    ST[j - 1] = ST[j];
                                        //    ST[j] = str;
                                        //}
                                        //else if (Left == Right)  //此處做如分數相同的條件
                                        //{
                                        //    //這裡要放case "N" 的內部程式碼 (不要含for，不然會整個以名字排序)

                                        //    pos1 = ST[j - 1].IndexOf(". ");
                                        //    pos2 = ST[j - 1].IndexOf("：");
                                        //    F = ST[j - 1].Substring(pos1 + 2, pos2 - (pos1 + 2));

                                        //    pos3 = ST[j].IndexOf(". ");
                                        //    pos4 = ST[j].IndexOf("：");
                                        //    S = ST[j].Substring(pos3 + 2, pos4 - (pos3 + 2));

                                        //    if (String.Compare(F, S) < 0)  //故意反過來，由大排到小
                                        //    {
                                        //        str = ST[j - 1];
                                        //        ST[j - 1] = ST[j];
                                        //        ST[j] = str;
                                        //    }

                                        //}
                                    }
                                }
                                for (int k = number - 1; k >= 0; k--)   //Descending:由大到小   /此迴圈用來重新排序
                                {
                                    Console.WriteLine(ST[k].S_No + ". " + ST[k].Name + "：" + ST[k].BCC + "+" + ST[k].CSharp + "+" + ST[k].DS + " = " + ST[k].Total);
                                }

                                break;

                            case "4":  //平均分數與"資料結構"分數皆及格？
                                for (int i = 0; i < number; i++)
                                {
                                    Console.Write(ST[i].S_No + ". " + ST[i].Name + "：" + ST[i].BCC + "+" + ST[i].CSharp + "+");
                                    if (ST[i].Total >= 180 && ST[i].DS >= 60)
                                    {
                                        Console.ForegroundColor= ConsoleColor.Green;
                                    }
                                    Console.WriteLine(ST[i].DS + " = " + ST[i].Total);
                                    Console.ForegroundColor = ConsoleColor.White;

                                    //pos1 = ST[i].IndexOf("：");
                                    //pos2 = ST[i].IndexOf("+");             // Index of the first "+"  第一個+
                                    //pos3 = ST[i].IndexOf("+", pos2 + 1);   // Index of the second "+" 第二個+
                                    //pos4 = ST[i].IndexOf("=");

                                    //Total = int.Parse(ST[i].Substring(pos4 + 1));  //不用從+2定位也可 (因為只會抓數值)
                                    //DS = int.Parse(ST[i].Substring(pos3 + 2, (pos4 - 1) - (pos3 + 2)));

                                    //Console.Write(ST[i].Substring(0, pos3 + 1));  //結束在第2個+ (要 + 1)

                                    //if (Total >= 60 && DS >= 60)
                                    //{
                                    //    Console.ForegroundColor = ConsoleColor.Green;
                                    //}

                                    //Console.WriteLine(ST[i].Substring(pos3 + 1));
                                    //Console.ForegroundColor = ConsoleColor.White;
                                }

                                break;

                            case "9":  //平均分數與"資料結構"分數皆及格？
                                for (int i = 0; i < number; i++)
                                {
                                    Console.Write(ST[i].S_No + ". " + ST[i].Name + "：");
                                    if (ST[i].BCC >= 60 && ST[i].DS >= 60 && ST[i].CSharp >= 60)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(ST[i].BCC + "+" + ST[i].CSharp + "+" + ST[i].DS);
                                    }
                                    else
                                    {
                                        Console.Write(ST[i].BCC + "+" + ST[i].CSharp + "+" + ST[i].DS);
                                    }
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(" = " +ST[i].Total);
                                }

                                break;

                            default:
                                break;
                        }
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
