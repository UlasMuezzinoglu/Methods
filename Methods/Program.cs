using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[] { };

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("-------------------METOTLAR---------------");

            //Instance Oluşturma
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product1);





        }
    }
}
