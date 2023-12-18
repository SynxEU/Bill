namespace Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            IBil benzilBil = new BenzilBil(50000) { Farve = "Blå"};
            IBil dieselBil = new DieselBil(70000) { Farve = "Sort"};

            benzilBil.UdskrivBil();
            dieselBil.UdskrivBil();
        }
    }
}
