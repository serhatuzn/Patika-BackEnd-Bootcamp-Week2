int i = 1; // 1 ile 20 arasındaki sayıları dedeği için 1 den başlatıyoruz 

while (i <= 20) // 1 ile 20 arasındaki sayılar döngüye sokuyorum
{
    if (i % 2 == 0) // 1 ile 20 arasındaki sayıları çiftse diyorum
    {
        Console.WriteLine(i); // yazdırıyoruz
    }
    i++; // çift olduğunda arttırıyoruz
}
