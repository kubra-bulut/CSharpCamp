using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam= sayi1 + sayi2;
            Console.WriteLine("Toplam:" + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int toplam = sayi1 - sayi2;
            Console.WriteLine("Fark:" + toplam);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int toplam = sayi1 * sayi2;
            Console.WriteLine("Çarpım:" + toplam);
        }
        public void Bolum(int sayi1, int sayi2)
        {
            int toplam = sayi1 / sayi2;
            Console.WriteLine("Bölüm:" + toplam);
        }
    }
}
