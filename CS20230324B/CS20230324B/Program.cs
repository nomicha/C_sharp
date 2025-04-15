using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20230324B
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
                        Console.Write("\r\n僅限使用單一個一維陣列\r\nINPUT number of Student？ Max. Length of Last Name？");
                        string[] Line = Console.ReadLine().Split(' ');
                        int number = int.Parse(Line[0]);
                        int namelength = int.Parse(Line[1]);
                        string Name;
                        //char Name;
                        int BCC, CSharp, DS, Total;

                        string[] ST = new string[number];  //ST指學生
                        Console.WriteLine("序號. 姓名：計概 + C# + 資料結構 = 總分");
                        for (int n =1; n <= number; n++)
                        {
                            Name = ((char)RN.Next(65, 91)).ToString();  //The first Capital 大寫部分
                            //前面放char是為了改變字元
                            for (int j = 1; j <= RN.Next(1, namelength); j++)  
                            {
                                Name += ((char)RN.Next(97, 123)).ToString();  //小寫部分
                            }
                            BCC = RN.Next(0, 101);
                            CSharp = RN.Next(0, 101);
                            DS = RN.Next(0, 101);
                            Total = BCC +CSharp + DS;

                            ST[n - 1] = n + ". " + Name + "：" + BCC + "+" + CSharp + "+" + DS + " = " + Total;

                            Console.WriteLine(ST[n - 1]);
                        }
                        int Left, Right;
                        string str;
                        Console.Write("======================================================\r\nSorting by Score(Descending)|Name(Ascending)|SN|[4]平均分數與資料結構皆及格？");
                        string[] which = Console.ReadLine().Split(' ');
                        switch (which[0])
                        {
                            case "S":
                                for (int i = 1; i < number - i; i++)  // nth Round 氣泡比較法回合數
                                {
                                    for (int j = 1; j <= number - i; j++)  // nth Round Comparison Times 比較次數
                                    {
                                        Left = int.Parse(ST[j - 1].Substring(ST[j - 1].IndexOf("=") + 2));  //Substring是為了抓數值
                                        Right = int.Parse(ST[j].Substring(ST[j].IndexOf("=") + 2));  
                                        //IndexOf是用來定位，而其後面的+2就是為了抓"="後的第2位數值 (因為中間有空格，所以是第2位)
                                        if (Left > Right)  //Swap ST[j - 1]  ST[j]
                                        {
                                            str = ST[j - 1];
                                            ST[j - 1] = ST[j];
                                            ST[j] = str;
                                        }
                                    }
                                }
                                for (int k = number - 1; k >= 0; k--)   //Descending:由大到小   /此迴圈用來重新排序
                                {
                                  Console.WriteLine(ST[k]);
                                }

                                break;

                            case "N":


                                break;
                            
                            case "SN":
                                
                                break;
                            
                            case "4":
                                
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
