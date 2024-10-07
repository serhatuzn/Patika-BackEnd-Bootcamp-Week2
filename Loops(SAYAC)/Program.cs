Console.Write("Limit değerini giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0;
while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

// while döngüsü, koşul sağlandığı sürece çalışır.
// Eğer limit negatif bir değer ise, döngü hiç çalışmaz ve "Ben bir Patika'lıyım" yazdırılmaz.


Console.Write("Limit değerini giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0;
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
} while (sayac <= limit);

// do-while döngüsü, en az bir kez çalışır.
// Yani, limit negatif bir değer olsa bile, en az bir kere "Ben bir Patika'lıyım" yazdırılır.