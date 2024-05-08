using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("vuvedi sinvolen niz");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (i > 0)
                    i--;
                {
                    Console.WriteLine(str[i]);
                }

            }

        }
       
    }
}
