using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._04._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Grupa Person1 = new Grupa();
            Person1.name = "Eli";
            Person1.ocenka = 6;
            Person1.adres = "Karnare";

            Person1.IntroduceYouself();

          Grupa Person2 = new Grupa();
            Person2.name = "Tsveti";
            Person2.ocenka = 5.67;
            Person2.adres = "Vedrare";
            
            Person2.IntroduceYouself();

            Grupa Person3 = new Grupa();
            Person3.name = "Silviya";
            Person3.ocenka = 5.57;
            Person3.adres = "Voynyagovo";

            Person3.IntroduceYouself();

        }
    }
}
