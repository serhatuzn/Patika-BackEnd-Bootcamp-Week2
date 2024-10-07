int toplam = 0; // Toplamı tutmak için bir değişken tanımlıyoruz.

int i = 50;  // Başlangıç sayısını tanımlıyoruz.

while (i <= 150)  // 50 ile 150 arasındaki sayılar için döngü
{
    toplam += i;  // Mevcut sayıyı toplam değişkenine ekliyoruz.
    i++;  // Sayıyı bir artırıyoruz.
}
Console.WriteLine($"Sayıların toplamı : {toplam}"); // Toplamı ekrana yazdırıyoruz.