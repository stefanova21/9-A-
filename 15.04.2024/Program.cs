using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                danni A = new danni();
                Console.WriteLine("kakvo qde dnes");
                A.Zakuska = Console.ReadLine();
                Console.WriteLine("kolko puti qde ");
                A.Broika = int.Parse(Console.ReadLine());

                A.izhod();
                if (A.Broika > 5)
                {
                    A.Broika = A.Broika*5;
                    Console.WriteLine("ti si ql "+A.Broika);
                }
                else
                {
                    Console.WriteLine("Broikata ti e pod 5 ");
                }

                A.izhod();
               
                    Console.WriteLine("TI pil li si nesho dnes");
                    string da = Console.ReadLine();
                if (da != "da")
                {
                    Console.WriteLine("Kakvo si pil");
                }
                else
                {
                    Console.WriteLine("Lek den");
                }
                


                   

            }
        }
    }
}
