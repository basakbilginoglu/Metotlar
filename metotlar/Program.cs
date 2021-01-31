using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "elma";
            product1.Fiyati = 15.00;
            product1.Aciklama = "amasya elması";
            Product product2= new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 20;
            product2.Aciklama = "Diyarbakır KArpzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine("------------");
            }
            Console.WriteLine(    "-------------     " );

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2); 
       
        }
    }
}
