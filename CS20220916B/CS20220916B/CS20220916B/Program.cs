using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20220916B
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

            //今天教運算子
            Console.WriteLine("1+2+3+4=?  A:" + 1 + 2 + 3 + 4);
            Console.WriteLine("1+2+3+4=?  A:" + (1 + 2 + 3 + 4));
            Console.WriteLine("(1+2+3+4-5)*5=?  A:" + (1 + 2 + 3 + 4 - 5) * 5);
            Console.WriteLine("(1+2+3+4-5)*5=?  A:" + (1 + 2 + 3 + 4 - 5) + 5);

            //如要讓數字後呈現小數，要讓被除數或除數至少呈現一位小數
            Console.WriteLine("1/3=?  A:" + (1 / 3));
            Console.WriteLine("1/3=?  A:" + (1.0 / 3.0));
            Console.WriteLine("1/3=?  A:" + (1 / 3.0));
            Console.WriteLine("1/3=?  A:" + (1.0 / 3));
            Console.WriteLine();
            Console.WriteLine("13+7 A:" + 13 + 7);
            Console.WriteLine("13+7 A:" + (13 + 7));
            Console.WriteLine("13-7 A:" + (13 - 7));
            Console.WriteLine("13*7 A:" + (13 * 7));
            Console.WriteLine("13/7 A:" + (13 / 7));
            Console.WriteLine("7/13 A:" + (7 / 13));
            Console.WriteLine("7/13 A:" + (7.0 / 13.0));
            Console.WriteLine();
            //以下本日最重要
            Console.WriteLine("13/7 A:" + (13.0 / 7.0));
            Console.WriteLine("13/7 A:" + Math.Round(13.0 / 7.0), 2);
            Console.WriteLine("13/7 A:" + Math.Round(13.0 / 7.0), 3);
            Console.WriteLine("13/7 A:" + Math.Round(13.0 / 7.0), 0);
 
            Console.ReadKey();

        }
    }
}
