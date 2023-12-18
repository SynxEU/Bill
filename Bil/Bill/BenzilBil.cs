using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    public class BenzilBil : IBil
    {
        public string Farve { get; set; }
        public int Km { get; private set; }

        public BenzilBil(int km)
        {
            Km = km;
        }
        public void UdskrivBil()
        {
            Console.WriteLine("BenzilBil - Farve: {0}, Km: {1}", Farve, Km);
        }
    }
}
