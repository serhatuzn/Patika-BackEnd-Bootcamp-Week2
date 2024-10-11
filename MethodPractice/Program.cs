using System;

namespace MethodPractice
{
    class Program
    {
        // Programın giriş noktası olan Main metodu. Burada diğer metotları çağırıyoruz.
        static public void Main(string[] args)
        {
            // Program sınıfından bir nesne oluşturuyoruz. Metotları bu nesne üzerinden çağıracağız.
            Program program = new Program();
            
            // sarkisozu metodunu çağırıyoruz. Bu metot ekrana bir şarkı sözü yazdıracak.
            program.sarkisozu();

            // kalansayidondur metodunu çağırıyoruz. Rastgele bir sayı üretip 2'ye bölümünden kalan sonucu geri döndürüyor.
            int kalan = program.kalansayidondur();
            // Kalan sonucu ekrana yazdırıyoruz.
            Console.WriteLine(kalan);

            // carp metodunu çağırıyoruz. İki sayıyı çarpıp sonucu geri döndürüyor.
            int carp = program.carp(5, 6);
            // Çarpım sonucunu ekrana yazdırıyoruz.
            Console.WriteLine(carp);

            // isimsoyisim metodunu çağırıyoruz. İsim ve soyisimi parametre olarak alıp ekrana hoş geldiniz mesajı yazdırıyor.
            program.isimsoyisim("Serhat", "Uzun");
        }

        // Geriye değer döndürmeyen bir void metot. Ekrana bir şarkı sözü yazdırır.
        public void sarkisozu()
        {
            Console.WriteLine("Uzun ince bir yoldayım gidiyorum gündüz gece");
        }

        // Geriye tamsayı döndüren bir metot. Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanını döndürür.
        public int kalansayidondur()
        {
            Random random = new Random(); // Rastgele sayı üretmek için Random sınıfından bir nesne oluşturuyoruz.
            int tamsayi = random.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı üretiyoruz.
            return tamsayi % 2; // Sayının 2'ye bölümünden kalanı döndürür.
        }

        // Parametre alan ve geriye tamsayı döndüren bir metot. İki sayıyı çarpıp sonucunu döndürür.
        public int carp(int a, int b)
        {
            return a * b; // İki sayıyı çarpar ve sonucu geri döndürür.
        }

        // Parametre alan ve geriye değer döndürmeyen bir metot. İsim ve soyisim alıp ekrana hoş geldiniz mesajı yazdırır.
        public void isimsoyisim(string isim, string soyisim)
        {
            Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}"); // İsim ve soyisim ile birlikte ekrana bir mesaj yazar.
        }
    }
}
