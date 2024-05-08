using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._04._2024
{
    internal class Grupa
    {
        public string name;
       public double ocenka;
       public string adres;
        private String Name
        {
            get { return name; }
            set { name = value; } 
        }
        public int Age
        {
            get { return Age; }
            set { Age = value; }
        }
        public void IntroduceYouself()
        {
            Console.WriteLine("Az sum {0}, moqta ocenka e {1}", name, ocenka);
            Console.WriteLine($" Moeto ime e  {this.name}, moqta ocenka e  {this.ocenka} and my adres is {this.adres}");
            Console.WriteLine("Az sum" + name, "moqta ocenka e " + ocenka, "adresa mi e" + adres);
        }




    }
}