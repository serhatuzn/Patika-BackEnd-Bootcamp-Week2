int teksayi = 0; // Tek sayıların toplamını tutacak değişken
int ciftsayi = 0; // Çift sayıların toplamını tutacak değişken

for (int i = 1; i <= 120; i++) // 1'den başlayarak 120'ye kadar olan sayılar arasında gezinmek için for döngüsü
{
    if (i % 2 == 0)
    {
        ciftsayi += i; // Çift sayıları toplamak için
    }
    else
    {
        teksayi += i; // Tek sayıları toplamak için
    }

}
Console.WriteLine($"Tek Sayilarin Toplami : {teksayi}");  // Tek sayıların toplamını ekrana yazdırır
Console.WriteLine($"Çift Sayilarin Toplami :{ciftsayi}");  // Çift sayıların toplamını ekrana yazdırır