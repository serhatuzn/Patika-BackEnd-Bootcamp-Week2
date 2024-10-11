// Geriye değer döndürmeyen bir metot: sarkisozu
// Ekrana sevdiğiniz bir şarkı sözünü yazdırır.
void sarkisozu()
{
    Console.WriteLine("Uzun ince bir yoldayım gidiyorum gündüz gece");
}

// Metot çağrısı: sarkisozu metodu çağrılarak şarkı sözü ekrana yazdırılır.
sarkisozu();

//--------------------------------------------------------

// Geriye tamsayı döndüren bir metot: tamsayidondur
// Rastgele bir sayı üretir ve bu sayının 2'ye bölümünden kalanı döndürür.
int tamsayidondur()
{
    // Rastgele bir sayı oluşturmak için Random sınıfı kullanılır.
    Random rnd = new Random();
    int sayi = rnd.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı üretir.
    return sayi % 2; // Üretilen sayının 2'ye bölümünden kalan döndürülür.
}

// Metot çağrısı: tamsayidondur metodu çağrılarak üretilen sayının kalan değeri alınır.
int sayi = tamsayidondur();
Console.WriteLine($"Dönen sayı: {sayi}");

//--------------------------------------------------------

// Parametre alan ve geriye tamsayı döndüren bir metot: carp
// İki sayının çarpımını döndürür.
int carp(int sayi1, int sayi2)
{
    return sayi1 * sayi2; // Verilen iki sayıyı çarpar ve sonucu döndürür.
}

// Metot çağrısı: carp metodu çağrılarak iki sayının çarpım sonucu ekrana yazdırılır.
int sonuc = carp(5, 10);
Console.WriteLine($"Çarpımın Sonucu: {sonuc}");

//--------------------------------------------------------

// Parametre alan ve geriye değer döndürmeyen bir metot: isimsoyisim
// Verilen isim ve soyisim değerlerini ekrana yazdırır.
void isimsoyisim(string ad, string soyad)
{
    Console.WriteLine($"Merhaba {ad} {soyad}"); // "Merhaba" şeklinde isim ve soyisim yazdırılır.
}

// Metot çağrısı: isimsoyisim metodu çağrılarak isim ve soyisim ekrana yazdırılır.
isimsoyisim("Serhat", "Uzun");
