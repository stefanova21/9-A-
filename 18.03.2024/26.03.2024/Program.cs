using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zadelqne na pamet
            Console.WriteLine("Vuvedi n elementi");
            int n = int.Parse(Console.ReadLine());
            string[] vidPitie = new string[n]; 
            int[] kolichestvo = new int[n];
            int[] broika = new int[n];
            // vhod 

            for (int i = 0; i < n; i++)
            {
               
                Console.WriteLine(" vidPitie ");
                vidPitie[i] = Console.ReadLine();
                Console.WriteLine("kolichestvo");
                kolichestvo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("broika");
                broika[i] = int.Parse(Console.ReadLine());
            }
            // izhod 1 
            for (int i = 0;i < n; i++)
            {
                

                Console.WriteLine($" Ti piesh  {vidPitie[i]} samo  {broika[i]} broika");
            }
            // izhod 2
            for (int i = 0; i  < n; i++)
            {
                
                Console.WriteLine($"Tvoite  {kolichestvo[i]} litri sa *1000 {kolichestvo[i]}  mililitri");
            }
            // izhod 3 vs. el. nad 2 
            for (int i = 0; i < n; i++)
            {
               if (broika[i] > 2)
                    Console.WriteLine($" Tvoite {kolichestvo[i]} litri sa + 1000 *  {kolichestvo[i]} ");

            }
            // izhod 4 sortirane - mehurche vuv nizhodqsh red
            for(int i = 0; i < n; i++)
            {
                for (int index = 0; index < broika.Length - 1; index++)
                {
                    for (int j = 0; j < broika.Length - 1; j++)
                    {
                        if (broika[j] > broika[j + 1])
                        {
                            int swapVar = broika[i];
                            broika[j] = broika[i + 1];
                            broika[i + 1] = swapVar;
                        }
                    }
                }
            }
            // izhod 5 sortirane - mehurche vuv vuzhodqsh red 
            for (int i = 0; i < n; i++)
            {
                for (int index = 0; index < kolichestvo.Length - 1; index++)
                {
                    for (int j = 0; j < kolichestvo.Length - 1; j++)
                    {
                        if (kolichestvo[j] < kolichestvo[j + 1])
                        {
                            int swapVar = kolichestvo[j];
                            kolichestvo[j] = kolichestvo[j + 1];
                            kolichestvo[j + 1] = swapVar;
                        }
                    }
                }
                Console.WriteLine
            }
         

        }
    }
}
