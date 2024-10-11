# Sayaç Uygulaması / Counter Application

Bu proje, kullanıcının girdiği bir limit değerine kadar 0'dan başlayarak bir sayaç çalıştırmakta ve her adımda "Ben bir Patika'lıyım" ifadesini yazdırmaktadır. Uygulama, iki farklı döngü yapısını (`while` ve `do-while`) kullanarak gerçekleştirilmiştir.

This project runs a counter starting from 0 up to a limit value provided by the user, printing "Ben bir Patika'lıyım" at each step. The application is implemented using two different loop structures (`while` and `do-while`).

## Proje İçeriği / Project Content

### 1. While Döngüsü / While Loop

`WhileLoopExample` sınıfı, kullanıcının girdiği limit değerine kadar sayaç artırarak "Ben bir Patika'lıyım" yazdırır. Eğer kullanıcı negatif bir değer girerse, döngü hiç çalışmaz.

The `WhileLoopExample` class increments the counter until the limit value provided by the user and prints "Ben bir Patika'lıyım". If the user enters a negative value, the loop does not execute.

```csharp
using System;

class WhileLoopExample
{
    static void Main(string[] args)
    {
        Console.Write("Limit değerini giriniz: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int sayac = 0;
        while (sayac <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;
        }
    }
}

// Burda ise Do-While ile

using System;

class DoWhileLoopExample
{
    static void Main(string[] args)
    {
        Console.Write("Limit değerini giriniz: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int sayac = 0;
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac ++;
        } while (sayac <= limit);
    }
}
