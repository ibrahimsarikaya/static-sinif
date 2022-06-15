using System;

namespace static_sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi); // CalisanSayisi ilk olarak 0 olduğu için çıktısı > "Çalışan Sayısı: 0"

            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK"); // İnstance oluşturup isim,soyisim,departmanını ekledik ve ayrıca calisanSayisi++ da burada çalıştı. Çünkü 1 tane çalışan bilgisi eklendi.
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi); // Çıktısı: "Çalışan Sayısı: 1"
            Calisan calisan1 = new Calisan("Deniz","Arda","IK"); // Yine farklı bir instance oluşturup veri ekledik.
            Calisan calisan2 = new Calisan("İbrahim","Sarıkaya","IK");//Aynı şekilde farklı bir instance oluşturup veri ekledik.
            Console.WriteLine("Çalışan Sayısı:{0}", Calisan.CalisanSayisi);//Çıktısı:"Çalışan Sayısı: 3"

            Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Topla(100,200));//Static işlemlerde "Islemler.Topla olarak yazılmaktadır."
            Console.WriteLine("Çıkarma İşlemi Sonucu: {0}", Islemler.Cıkar(400,50));

        }

    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan() 
        {
            calisanSayisi = 0;
        }

        public Calisan(string isims, string soyisim, string departman)
        {
            this.Isim = isims;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}