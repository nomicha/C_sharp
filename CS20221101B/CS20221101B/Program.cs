using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20221101B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# - Decision Making 做決定

            //Declaration 宣告
            double Waist, Height, Weight, BMI;
            string FM;
            bool sex;    //bool = Boolean value布林值
            //性別  Female:false(0) ; Male:true(1)

            while (true)
            {


                try
                {
                    Console.WriteLine("\r\n**************************************************\r\n\r\nBMI(Body Mass Index)\r\n資料來源: http://zh.wikipedia.org/wiki/身高體重指數\r\n\r\n==================================================");
                    Console.Write("\n請輸入性別-女[Female](0/f/F)男[Male](1/m/M)？");
                    FM = Console.ReadLine();

                    if (FM == "0" || FM == "f" || FM == "F")
                    {
                        sex = false;
                        Console.WriteLine("性別: 女(False)");
                    }
                    else if (FM == "1" || FM == "m" || FM == "M")
                    {
                        sex = true;
                        Console.WriteLine("性別: 男(True)");
                    }
                           //    ||是一個OR的概念
                    else
                    {
                        Console.WriteLine("性別選擇錯誤!");
                        //return; 強制結束程式
                        //break; 順著程式邏輯，也會結束
                        continue; //讓程式可以重新繼續
                    }
                    // if 、else if 、else 任選其一，就不會再出現其他選項


                    Console.Write("請輸入腰圍(cm)?");
                    Waist = double.Parse(Console.ReadLine());

                    Console.Write("請輸入身高(cm)?");
                    Height = double.Parse(Console.ReadLine());

                    Console.Write("請輸入體重(kg)?");
                    Weight = double.Parse(Console.ReadLine());

                    BMI = Weight / Math.Pow(Height / 100, 2);
                    Console.WriteLine("BMI(體質數[" + BMI + "])= " + Math.Round(BMI,1));
                    BMI = Math.Round(BMI, 1);

                }
                catch (Exception EX)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(EX);
                    Console.ForegroundColor = ConsoleColor.White;
                }  
                finally
                {
                    Console.WriteLine(".........Pause(Press any key to continue)");
                    Console.ReadKey();

                }
            }
        }
    }
}
