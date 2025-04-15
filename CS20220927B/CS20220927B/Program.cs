using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS20220927B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //教 Remark 或 unremark
            //Console.Write("111上學期資一乙\n");
            //Console.Write("I'm Gu.");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("111上學期資一乙\n");
            //Console.Write("I'm Gu.");

            ////今天教運算子
            //Console.WriteLine("1+2+3+4=?  A:" + 1 + 2 + 3 + 4);
            //Console.WriteLine("1+2+3+4=?  A:" + (1 + 2 + 3 + 4));
            //Console.WriteLine("(1+2+3+4-5)*5=?  A:" + (1 + 2 + 3 + 4 - 5) * 5);
            //Console.WriteLine("(1+2+3+4-5)*5=?  A:" + (1 + 2 + 3 + 4 - 5) + 5);

            ////如要讓數字後呈現小數，要讓被除數或除數至少呈現一位小數
            //Console.WriteLine("1/3=?  A:" + (1 / 3));
            //Console.WriteLine("1/3=?  A:" + (1.0 / 3.0));
            //Console.WriteLine("1/3=?  A:" + (1 / 3.0));
            //Console.WriteLine("1/3=?  A:" + (1.0 / 3));
            //Console.WriteLine();
            //Console.WriteLine("13+7 A:" + 13 + 7);
            //Console.WriteLine("13+7 A:" + (13 + 7));
            //Console.WriteLine("13-7 A:" + (13 - 7));
            //Console.WriteLine("13*7 A:" + (13 * 7));
            //Console.WriteLine("13/7 A:" + (13 / 7));
            //Console.WriteLine("7/13 A:" + (7 / 13));
            //Console.WriteLine("7/13 A:" + (7.0 / 13.0));
            //Console.WriteLine();
            ////以下9/16最重要
            //Console.WriteLine("13/7 A:" + (13.0 / 7.0));
            //Console.WriteLine("13/7 A:" + Math.Round(13.0 / 7.0), 2);
            //Console.WriteLine("13/7 A:" + Math.Round(13.0 / 7.0), 3);
            //Console.WriteLine("13/7 A:" + Math.Round(13.0 / 7.0), 0);

            ////9/20 教%        \n一定要放到字串才能使用
            //Console.WriteLine("13%7 A:" + (13 % 7) + "\n" );

            ////"Math"是class library，也就是程式從"圖書館"裡抽取數學公式   "Power"就是指數
            //Console.WriteLine("3^3= A:" + Math.Pow(3, 3) + "\n");

            //Console.WriteLine("144^1/2= A:" + Math.Pow(144, 1 / 2));
            //Console.WriteLine("144^1/2= A:" + Math.Pow(144, 1.0 / 2.0));
            //Console.WriteLine("144^1/2= A:" + Math.Pow(144, 0.5));
            //Console.WriteLine("343^1/3= A:" + Math.Pow(343, 1.0 / 3.0));

            ////C# Tutorial 課程<Data Types><Value Type>                         
            ////https://www.tutorialspoint.com/csharp/csharp_data_types.htm      
            ////一般運算使用int(32-bit)     
            //Console.WriteLine("123 * 456= A:" + (123 * 456));
            ////下面列式不能使用，因為byte不能超過255
            ////Console.WriteLine("123 * 456= A:" + ((byte)123 * ((byte)456)));

            ////下面可以使用，雖然答案超過byte，但會用預設的int顯示
            //Console.WriteLine("123 * 255= A:" + ((byte)123 * ((byte)255)));

            ////下面列式不能使用，因為答案超過int
            ////Console.WriteLine("123456 * 456789= A:" + (123456 * 456789));
            ////Console.WriteLine("123456 * 456789= A:" + ((int)123456 * 456789));

            ////但只要轉換一個，就可以讓他轉換成long
            //Console.WriteLine("123456 * 654321= A:" + ((long)123456 * (654321)));
            //Console.WriteLine("1234567890 * 9876543210= A:" + ((decimal)1234567890 * 9876543210));

            ////下面列式錯誤 因為答案超過int  *+-2147483647是int最大值
            ////Console.WriteLine("2147483647 +1 A:" + (2147483647 + 1));
            ////Console.WriteLine("-2147483647 -1 A:" + (-2147483648 - 1));

            //Console.WriteLine("2147483647 +1 A:" + (2147483647 + (long)1));
            //Console.WriteLine("-2147483647 -1 A:" + (-2147483647 - (long)1));

            ////下面一行錯誤，因為 9223372036854775808 是long最大值，所以要改成decimal                  
            ////Console.WriteLine("9223372036854775808 +1= A:" + (9223372036854775808 + (long)1));      
            //Console.WriteLine("9223372036854775808 +1= A:" + (9223372036854775808 + (decimal)1));

            ////最後一個概念 <Defining Variables><Initializing Variables>                   
            ////https://www.tutorialspoint.com/csharp/csharp_variables.htm                  

            ////2a.Defining下定義 Variables變數(Declarartion, 宣告資料型態)                 
            ////int Y;      //32 bit space                                                                
            ////int X;									  
            //int X, Y; //不能重複宣告，因此上面兩行為多餘								  

            ////2b.Initializing賦予初值 Variables(right value assign to left variable 把右值賦予給左邊的變數)   
            //X = 7;
            //Y = 3;
            ////7 = X;     //不可這樣寫，因為一定要把變數放左，值放右					



        ////  9/23  ++--
        //// X++會在下一行成效，但++X會在這行就成效
        ////Console.WriteLine("X++ = A:" + (X++));   //X = X+1; 7 	
        ////Console.WriteLine("++X= A:" + (++X));    //X = X+1; 8

        ////Console.WriteLine("Y-- = A:" + (Y--));   //Y = Y-1; 3 	
        ////Console.WriteLine("--Y= A:" + (--Y));    //Y = Y-1; 2

        //X++;  //X=X+1
        //Y++;  //Y=Y+1
        //      //   X = 8    Y = 4
        //      //Y = X++;    // Y = 8 (被上個X++賦予了"8"的值，因為這次的X++還未成效)
        //Y = ++X;      // Y = 9
        //Console.WriteLine("X= A:" + X);
        //Console.WriteLine("Y= A:" + Y);
        //Console.WriteLine("X+Y= A:" + (X + Y));


        //long A = 123456789012345678;
        //long B = 987654321098765432;
        //Console.WriteLine("A+B= A:" + (A + B));
        //Console.WriteLine("A*B= A:" + (A * B));       ///?????Overflow溢位 (可能變負數)
        //Console.WriteLine("A+B= A:" + (123456789012345678 + 987654321098765432));
        ////Console.WriteLine("A*B= A:" + (123456789012345678 * 987654321098765432));
        ////上面那行，因為不是變數所以系統會直接提醒錯誤

        //int C = 2147483647;
        //int D = 2;
        //Console.WriteLine("C+D = " + (C + D));  ///?????Overflow溢位
        //Console.WriteLine("C+D = " + (C + (long)D));

        ////如果要檢查有沒有溢位:
        //checked
        //{
        //    //Console.WriteLine("C+D = " + (C + (long)D));  //正常
        //    //Console.WriteLine("A*B= A:" + (A * B));       ///?????Overflow溢位
        //    //Console.WriteLine("C+D = " + (C + D));        ///?????Overflow溢位
        //}



        //// 9/27   3.ReadLine for string 用輸入定義X,Y
        //Console.Write("INPUT X?");
        ////Console.WriteLine("INPUT X?");  //會換行
        ////string X = Console.ReadLine();  //打"123"     
        //int X = int.Parse(Console.ReadLine());     

        //Console.WriteLine("INPUT Y?");
        //string Y = Console.ReadLine();  //打"456"
        ////int Y = int.Parse(Console.ReadLine());

        ////兩個都用string就只是把字串加在一起，會變成"123456"
        ////兩個都用int可以把數字本身加在一起，會變成"579"
        ////Console.WriteLine("X+Y= A:" + (X + Y));
        
        ////如只需要把一個其中一個字串成int，需要在變數上面冠上 int.Parse()
        //Console.WriteLine("X+Y= A:" + (X + int.Parse(Y)));


        while(true)
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

        Console.WriteLine("X+Y= A:" + (X + Y));
        Console.WriteLine("X-Y= A:" + (X - Y));
        Console.WriteLine("X*Y= A:" + (X * Y));
        Console.WriteLine("X/Y= A:" + (X / Y));
        Console.WriteLine("X%Y= A:" + (X % Y));
        Console.WriteLine("X^Y= A:" + Math.Pow(X, Y));
        
        Console.WriteLine("X/Y(Round)= A:" + Math.Round(X / Y,1));  //這行回去重聽
        Console.WriteLine("X^Y(Round)= A:" + Math.Round(Math.Pow(X, Y),1));
                
        Console.WriteLine();
        }




            Console.ReadKey();

        }
    }
}