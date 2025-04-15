using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS20221004B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {

                //  10/4 Exception Handling 例外處理
                
                try  //讓括號裡的例外被激活
                {
                    //4.ReadLine with delimiter分隔符   //Split = 分割
                    Console.Write("INPUT X=? INPUT Y =?");
                    //下面這行是先定義line為變數，再把他用分割的方式，來分出數列
                    string[] line = Console.ReadLine().Split(' ');  //' ':delimiter 空格是分隔符
                    //string[] line = Console.ReadLine().Split('$');  //'$':delimiter $是分隔符
                    //Console.WriteLine(line[0] + line[1]);
                    //Console.WriteLine(line[0] + line[1] + line[2] + line[3]);


                    //int X = int.Parse(line[0]);
                    //int Y = int.Parse(line[1]);

                    //double 可以自動讓值變成小數形式
                    double X = double.Parse(line[0]);
                    double Y = double.Parse(line[1]);

                    checked
                    {
                        Console.WriteLine("X+Y= A:" + (X + Y));
                        Console.WriteLine("X-Y= A:" + (X - Y));
                        Console.WriteLine("X*Y= A:" + (X * Y));
                        Console.WriteLine("X/Y= A:" + (X / Y));
                        Console.WriteLine("X%Y= A:" + (X % Y));
                        Console.WriteLine("X^Y= A:" + Math.Pow(X, Y));

                        Console.WriteLine("X/Y(Round)= A:" + Math.Round(X / Y, 1));  //這行回去重聽
                        Console.WriteLine("X^Y(Round)= A:" + Math.Round(Math.Pow(X, Y), 1));
                    }
                }
                catch(Exception EX)  //把例外情況放到EX
                {
                    Console.ForegroundColor = ConsoleColor.Red;  //ForegroundColor 字體顏色
                    Console.WriteLine(EX);  //這行讓放在EX的錯誤問題，可以顯示在程式上
                    //Console.WriteLine(EX.Message);  //使用Message可簡短說明原因
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally  //不論有沒有例外，都要執行括號內的程式
                {
                    Console.WriteLine("\n~Press any key for continue~\n");
                    Console.ReadKey();
                }


                

                
            }




            

        }
    }
}