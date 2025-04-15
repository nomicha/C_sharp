using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
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
                        Console.Write("學號第1碼[B]；第2-3碼[08~11,大四三二一]；第4-6碼[090]；第7-9碼[001-999]\r\n學號：計概 + 資料庫 + 程式設計 = 總分\r\nNumber of ID？[1,1000]");
                        
                        int Number = int.Parse(Console.ReadLine());  //一個的話，用ReadLine()就好
                        Console.ForegroundColor = ConsoleColor.White;
                        string Name;
                        string[] ST = new string[Number];  //ST指學生

                        int grade, N3, BCC, DB, CS;  //3科
                        for(int n = 0;n < Number; n++)
                        {
                            ST[n] = (n + 1) + ". B";  //第1碼

                            grade = RN.Next(8, 12);  //第2-3碼
                            if (grade < 10) ST[n] += "0" + grade.ToString();
                            else ST[n] += grade.ToString();

                            ST[n] += "090";  //第4-6碼

                            N3 = RN.Next(1, 1000);  //第7-9碼
                            if (N3 <= 9) ST[n] += "00" + N3.ToString(); 
                            else if (N3 >= 10 && N3 <= 99) ST[n] += "0" + N3.ToString();
                            else ST[n] += N3.ToString();

                            BCC = RN.Next(1, 101);
                            DB = RN.Next(1, 101);
                            CS = RN.Next(1, 101);

                            ST[n] += "：" + BCC + "+" + DB + "+" + CS + " = " + (BCC + DB + CS);

                        }
                        for (int i = 0; i < Number; i++) Console.WriteLine(ST[i]);

                        Console.Write("==============================\r\n[1]總平均分數[Ascending]介於？？ [2]依年級高低(Ascending)與總分(Descending)排序？");


                        int Left, Right;
                        double Avg;   //這邊改為Avg，而且要用double
                        string F, S;  
                        string str, Fg, Sg;
                        int B08, B09, B10, B11;
                        string[] Line = Console.ReadLine().Split(' ');
                        switch (Line[0])
                        {
                            case "1":
                                for (int i = 1; i < Number; i++)  //nth Round
                                {
                                    for (int j = 1; j <= Number - i; j++)  
                                    {
                                        Left = int.Parse(ST[j - 1].Substring(ST[j - 1].IndexOf("=") + 2));  
                                        Right = int.Parse(ST[j].Substring(ST[j].IndexOf("=") + 2));
                                        if (Left > Right)  //Swap ST[j - 1]  ST[j]
                                        {
                                            str = ST[j - 1];
                                            ST[j - 1] = ST[j];
                                            ST[j] = str;
                                        }
                                    }
                                }
                                for (int k = 0;k <= Number-1; k++)   //由小到大 
                                {
                                    //Console.WriteLine(ST[k]);
                                    Avg = double.Parse(ST[k].Substring(ST[k].IndexOf("=") + 2)) / 3.0;  //平均數就是總數除以3
                                    Avg = Math.Round(Avg, 1);  //取到小數第一位
                                    if (Avg >= double.Parse(Line[1]) && Avg <= double.Parse(Line[2]))
                                    {
                                        Console.ForegroundColor= ConsoleColor.Green;
                                        Console.WriteLine(ST[k] + "(" + Avg + ")" );
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else Console.WriteLine(ST[k] + "(" + Avg + ")");
                                }

                                Console.WriteLine("==================================");

                                break;

                            case "2":    //先用分數排序由大到小，而遇到分數相同的，再用名字由A到Z
                                for (int i = 1; i < Number; i++)  //這邊先把case "S" 的複製
                                {
                                    for (int j = 1; j <= Number - i; j++)
                                    {
                                        Fg = (ST[j - 1].Substring(ST[j - 1].IndexOf("B") + 1, 2));  //從 "B" 的後面取2位
                                        Sg = (ST[j].Substring(ST[j].IndexOf("B") + 1, 2));
                                        if ( string.Compare(Fg, Sg) < 0 )
                                        {
                                            str = ST[j - 1];
                                            ST[j - 1] = ST[j];
                                            ST[j] = str;
                                        }
                                        else if ( Fg == Sg)
                                        {
                                            Left = int.Parse(ST[j - 1].Substring(ST[j - 1].IndexOf("=") + 2));
                                            Right = int.Parse(ST[j].Substring(ST[j].IndexOf("=") + 2));
                                            if (Left > Right)
                                            {
                                                str = ST[j - 1];
                                                ST[j - 1] = ST[j];
                                                ST[j] = str;
                                            }
                                        }
                                    }
                                }
                                
                                B08 = 0;  B09 = 0;  B10 = 0;  B11 = 0;

                                for (int k = Number - 1; k >= 0; k--)   //Descending:由大到小   /此迴圈用來重新排序
                                {
                                    Console.WriteLine(ST[k]);
                                    switch(ST[k].Substring(ST[k].IndexOf("B") + 1 , 2))
                                    {
                                        case "08":
                                            B08++;
                                            break;
                                        case "09":
                                            B09++;
                                            break;
                                        case "10":
                                            B10++;
                                            break;
                                        case "11":
                                            B11++;
                                            break;
                                    }
                                }
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("大四：" + B08 + "人");
                                Console.WriteLine("大三：" + B09 + "人");
                                Console.WriteLine("大二：" + B10 + "人");
                                Console.WriteLine("大一：" + B11 + "人");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("==================================");

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
