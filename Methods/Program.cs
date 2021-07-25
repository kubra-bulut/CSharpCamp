using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun = new Product();
            urun.Adi = "Çilek";
            urun.Id =1;
            urun.Fiyati =12;
            urun.Aciklama = "";

            Product urun1 = new Product 
            { 
                Adi="elma",
                Id=2,
                Fiyati=10,
                Aciklama="Amasya"
            };

            Product[] products = new Product[] {urun, urun1 };
            foreach ( Product  product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("-------Metotlar-------");
            BasketManager basketManager = new BasketManager();
            
            basketManager.Ekle(urun1);
            basketManager.Ekle(urun);

            basketManager.Ekle2("Armut","Yeşil Armut",12,10);
            basketManager.Ekle2("Elma", "Yeşil Elma", 12,7);
            basketManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,5);
            Console.ReadKey();
        }
    }
}
