using System;

namespace classdeneme2
{
    class Program
    {
        static void Main(string[] args)
        {
            product urun1 = new product();
            urun1.urunAdi = "hp bilgisayar";
            urun1.urunFiyati = 3899.99;
            urun1.urunYorumSatiri = "Sepette %23 indirimli fiyat";
            urun1.urunPuani = 3.9;
            urun1.urunDegerlendirme = 19;

            product urun2 = new product();
            urun2.urunAdi = "hp monitor";
            urun2.urunFiyati = 1400;
            urun2.urunYorumSatiri = "Sepette %24 indirimli fiyat";
            urun2.urunPuani = 4.1;
            urun2.urunDegerlendirme = 34;

            product[] dizi = new product[] {urun1,urun2 };

            foreach (var dongu in dizi)
            {
                Console.WriteLine("Ürün Adi "+dongu.urunAdi+" Ürün Fiyatı "+dongu.urunFiyati+" "+dongu.urunYorumSatiri
                 +"Ürün Puanı"+dongu.urunPuani+dongu.urunDegerlendirme);
            }



            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }

    class product
    {
        public string urunAdi { get; set; }
        public double urunFiyati { get; set; }
        public string urunYorumSatiri { get; set; }
        public double urunPuani { get; set; }
        public int  urunDegerlendirme { get; set; }

    }





}
