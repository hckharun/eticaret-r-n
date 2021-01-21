using System;

namespace eticaretÜrün
{
    class Program
    {
        static void Main(string[] args)
        {
            
            urun urun1 = new urun();
            urun1.ÜrünAdı = "Televizyon";
            urun1.Kategori = "Elektronik";
            urun1.Fiyat = 4000;
            urun1.İndirim = 10;
            urun1.Kargo24 = "Var";

            
            urun urun2 = new urun();
            urun2.ÜrünAdı = "Ceket";
            urun2.Kategori = "Moda";
            urun2.Fiyat = 250;
            urun2.İndirim = 30;
            urun2.Kargo24 = "Yok";

            urun[] urunler = new urun[] { urun1, urun2 };
            foreach (urun urunset in urunler)
            {
                Console.WriteLine(urunset.ÜrünAdı + Environment.NewLine +
                    "Kategori:" + urunset.Kategori + Environment.NewLine +
                    "Fiyat:" + urunset.Fiyat + Environment.NewLine +
                    "İndirim:" + "%" + urunset.İndirim + Environment.NewLine +
                    "24 Saatte Kargo :" + urunset.Kargo24);
                Console.WriteLine("------------------------");

            }


        }
        class urun
        {
            public string ÜrünAdı { get; set; }
            public string Kategori { get; set; }
            public int Fiyat { get; set; }
            public int İndirim { get; set; }
            public string Kargo24 { get; set; }
        }



    }

}
