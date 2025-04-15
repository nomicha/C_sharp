using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CS20230428B
{
    internal class Eratosthenes
    {
        public int[] PrimeNO = new int[100001];   //PrimeNO[1]=2 ~ PrimeNO[1000000]
        public void Create()
        {
            PrimeNO[1] = 2; PrimeNO[2] = 3; PrimeNO[3] = 5; PrimeNO[4] = 7;
            int N = 11;
            int np, SqaueRoot;  //SqaueRoot開根號
            for (int n = 5; n <= 100000; n++)
            {
                SqaueRoot = (int)Math.Sqrt(N) + 2;
                np = 1;
                
                while(SqaueRoot >= PrimeNO[np])   //此迴圈判斷 N 是否是質數
                {
                    if (N % PrimeNO[np] == 0)  //此數最終都會經過這個if，此為判斷 N 是否能跟第np項數列除盡
                    {
                        N++;
                        SqaueRoot = (int)Math.Sqrt(N) + 1;
                        np = 1;   //np會回到1，方便下個數字判斷
                    }
                    else np++;
                }
               
                PrimeNO[n] = N;
                //Console.WriteLine("P" + n + " = " + PrimeNO[n]);
                N++;
            }
            Console.WriteLine("PrimeNo[1000] = " + PrimeNO[1000]);
            Console.WriteLine("PrimeNo[100000] = " + PrimeNO[100000]);
            Console.WriteLine("(int)PrimeNo[100000] ^ 2 = " + PrimeNO[100000] * PrimeNO[100000]);
            Console.WriteLine("(long)PrimeNo[100000] ^ 2 = " + (long)PrimeNO[100000] * (long)PrimeNO[100000]);

        }

        public bool Test(long N)
        {
            if (N < 2) return false;
            else if (N ==2) return true;
            else if (N % 2 == 0) return false;
            else
            {
                int ptr = 1;
                int SRoot = (int)Math.Sqrt(N) + 1;
                while (SRoot > PrimeNO[ptr])
                //while (N >= PrimeNO[ptr] * (long)PrimeNO[ptr])
                {
                    if (N % PrimeNO[ptr] == 0) return false;
                    else ptr++;
                }
                
                return true;
            }
            
        }
    }
}
