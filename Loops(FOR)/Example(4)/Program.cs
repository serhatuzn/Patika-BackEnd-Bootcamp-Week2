int tplm = 0;    // Toplamı tutacak bir değişken tanımlıyoruz ve başlangıç değeri olarak 0 atıyoruz

for (int i = 50; i < 150; i++)    // 50'den başlayıp 150'ye kadar olan sayılar arasında döngü başlatıyoruz
{
    tplm += i;     // Döngü her çalıştığında, 'i' değeri tplm değişkenine ekleniyor
}
Console.WriteLine(tplm);    // Döngü tamamlandıktan sonra toplam değeri ekrana yazdırıyoruz
