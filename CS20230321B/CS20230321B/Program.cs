using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20230321B
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
                        Console.Write("\nINPUT number of Student?");
                        string[]Line = Console.ReadLine().Split(' ');
                        int Number = int.Parse(Line[0]);  
                        int[] Score = new int[Number];
                        for (int i = 0; i < Number; i++)  
                            //這邊終止值 i要小於Number 是因為序號包含0，為了不多出一個
                            //假設輸入10，此迴圈會出現0~9
                        {
                            Score[i] = RN.Next(0, 101);
                        }

                        Console.Write("\nUnsorted Scores:");

                        for(int i = 0; i < Number; i++)
                        {
                            Console.Write(Score[i] + ", ");
                        }
                        //Sorting


                        int temp;
                        for (int i = 1; i < Number; i++)  //nth Round，i就是回合數
                        {
                            for(int j = 1; j <= Number - i; j++)//nth Round Comparison Times 比較次數
                            //nth Round Comparison Times : N - (nth Round-1) - 1 = N - nth Round (也就是i) 
                            {
                                if (Score[j - 1] > Score[j])
                                {
                                    temp = Score[j - 1];
                                    Score[j - 1] = Score[j];
                                    Score[j] = temp;
                                }
                            }
                        }
                        Console.Write("\n\nSorted Scores(Ascending):");
                        for(int i = 0; i < Number; i++)
                        {
                            Console.Write(Score[i] + ", ");
                        }
                        Console.Write("\n\nSorted Scores(Descending):");
                        for (int i = Number - 1; i >= 0; i--)
                        {
                            Console.Write(Score[i] + ";");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    //Console.WriteLine("Press any key to continue!\n\n");
                    //Console.ReadKey();
                    //Console.Write("Next........\n\n");
                    //System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }
}
