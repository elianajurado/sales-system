using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller a1 = new Seller();
            a1.name = "Jacob";
            a1.age = 33;

            Seller a2 = new Seller();
            a2.name = "marian";
            a2.age = 27;

            Seller a3 = new Seller();
            a3.name = "Harry";
            a3.age = 27;

            Product b1 = new Product();
            b1.name = "Shampoo";
            b1.price = 22000;

            Product b2 = new Product();
            b2.name = "Eye Shadow";
            b2.price = 259000;

            Product b3 = new Product();
            b3.name = "Red Lipstick";
            b3.price = 25000;

            Console.Write(b2.price + b1.price + b3.price);

        }
    }
}
