using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    public class DieselBil : IBil
    {
        public string Farve { get; set; }
        public int Km { get; private set; }

        public DieselBil(int km)
        {
            Km = km;
        }

        public void UdskrivBil()
        {
            Console.WriteLine("DieselBil - Farve: {0}, Km: {1}", Farve, Km);
        }
    }
}
