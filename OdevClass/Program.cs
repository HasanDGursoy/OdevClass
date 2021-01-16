using System;

namespace OdevClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Products urun1 = new Products();
            urun1.ProductsName = "Paşa Bahçe Çay Bardağı 6'lı";
            urun1.ProductsDetails = "Stokta Var / En geç 19 Ocak'da Kargoya verilcek";
            urun1.ProductsCost = 100;

    Products urun2 = new Products();
            urun2.ProductsName = "The Silmarilion";
            urun2.ProductsDetails = "Stokta Var / En geç 16 Ocak'da Kargoya verilcek";
            urun2.ProductsCost = 55;

    Products urun3 = new Products();
            urun3.ProductsName = "Şişme Yatak";
            urun3.ProductsDetails = "Stokta Var / Bu gün Kargoda";
            urun3.ProductsCost = 250;

    Products[] urunler = new Products[] { urun1, urun2, urun3 };

            foreach (Products urunBilgileri in urunler)
            {
                Console.WriteLine("Ürünün İsmi :" + urunBilgileri.ProductsName);
                Console.WriteLine("Ürünün Detayları :"+urunBilgileri.ProductsDetails);
                Console.WriteLine("Ürünün Fiyatı :" + urunBilgileri.ProductsCost);
            }
        }
    }
    class Products
    {
        public string ProductsName { get; set; }
        public string ProductsDetails { get; set; }
        public int ProductsCost { get; set; }
    }
}
