using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20221104B
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

                    // 11/4
                    //1.Dichotomy(二分法)
                    //if (BMI < 18.5) Console.WriteLine("體重過低");
                    //else Console.WriteLine("體重正常或超重\n");  // \n: new line 

                    //2.tripartition(三分法)
                    //if (BMI < 18.5) Console.WriteLine("體重過低!!");
                    //else if (BMI > 23.9) Console.WriteLine("體重過重!!");
                    //else Console.WriteLine("體重正常!!");

                    ////3.Classify(精確分類)
                    //if (BMI < 18.5) Console.WriteLine("體重過低!!");
                    //else if (BMI >= 18.5 && BMI <= 23.9) Console.WriteLine("體重正常!!");
                    //else if (BMI >= 24.0 && BMI <= 27.9) Console.WriteLine("超重!!");
                    //else if (BMI >= 28d) Console.WriteLine("肥胖!!");  
                    //                //d: double 把28轉換成小數，以防需要用到多位小數
                    //                //這題也可以只用28.0，因為前面小數已經取到小數點後一位
                    ////else Console.WriteLine("肥胖");

                    if (BMI < 18.5)
                    {
                        Console.WriteLine("體重過低!!");
                        //1.
                        //if ( (sex == true && Waist >= 95d) || (sex == false && Waist >= 90d) ) Console.WriteLine("腰圍危險");
                        //2.
                        if ((sex == true && Waist >= 95d) || (sex == false && Waist >= 90d)) Console.WriteLine("腰圍危險");

                    }

                    //下面要補完
                    else if (BMI >= 18.5 && BMI <= 23.9)
                    {
                        Console.WriteLine("體重正常!!");
                        if ((sex == true && Waist >= 95d) || (sex == false && Waist >= 90d)) Console.WriteLine("腰圍高危險");
                        else if ((sex == true && Waist >= 85d && Waist < 95d) || (sex == false && Waist >= 80d && Waist < 90d)) Console.WriteLine("腰圍危險");
                    }
                    else if (BMI >= 24.0 && BMI <= 27.9) 
                    {
                        Console.WriteLine("超重!!");
                        if ((sex == true && Waist >= 95d) || (sex == false && Waist >= 90d)) Console.WriteLine("腰圍極高危險");
                        else if ((sex == true && Waist >= 85d && Waist < 95d) || (sex == false && Waist >= 80d && Waist < 90d)) Console.WriteLine("腰圍高危險");
                        else if ((sex == true && Waist < 85d) || (sex == false && Waist < 80d)) Console.WriteLine("腰圍危險");
                    }
                    else if (BMI >= 28d) 
                    {
                        Console.WriteLine("肥胖!!");
                        if ((sex == true && Waist >= 95d) || (sex == false && Waist >= 90d)) Console.WriteLine("腰圍最極高危險");
                        else if ((sex == true && Waist >= 85d && Waist < 95d) || (sex == false && Waist >= 80d && Waist < 90d)) Console.WriteLine("腰圍極高危險");
                        else if ((sex == true && Waist < 85d) || (sex == false && Waist < 80d)) Console.WriteLine("腰圍高危險");
                    }

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
