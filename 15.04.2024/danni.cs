using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._2024
{
    internal class danni
    {
        private string zakuska;
        private int broika;
        private string pitieta;
        public String Zakuska 
        {
            get { return zakuska; }
            set { zakuska = value; }
        }

        public int Broika
        {
            get { return Broika; }  
            set { Broika = value; }
        }
        public String Pitieta 
        {
            get { return Pitieta; }
            set { Pitieta = value; }
        }

        public void izhod()
        {
            Console.WriteLine(" ti dnes si ql {0} puti i si ql {1}",zakuska , broika);
        }

       

    }
}
