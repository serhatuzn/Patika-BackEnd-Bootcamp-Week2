int teksayi = 0; // Tek sayıların toplamını tutmak için bir değişken tanımlıyoruz.
int ciftsayi = 0; // Çift  sayıların toplamını tutmak için bir değişken tanımlıyoruz.

int  i = 1; // Döngü için başlangıç sayısını 1 olarak belirliyoruz.
while (i <= 120) // 1 ile 120 arasındaki sayılar için döngü başlıyor.
{
    if (i % 2 == 0) // Eğer i sayısı 2'ye tam bölünebiliyorsa (çift sayıysa)
    {
        ciftsayi += i; // Çift sayıyı çift sayıların toplamına ekliyoruz.
        i++; // Sayıyı bir artırıyoruz.
    }
    else // Eğer i sayısı 2'ye tam bölünemiyorsa (tek sayıysa)
    {
        teksayi += i;  // Tek sayıyı çift sayıların toplamına ekliyoruz.
        i++; // Sayıyı bir arttırıyoruz
    }
}
Console.WriteLine($"Tek Sayilarin toplamı : {teksayi}");
Console.WriteLine($"Cift Sayilarin toplami : {ciftsayi}");