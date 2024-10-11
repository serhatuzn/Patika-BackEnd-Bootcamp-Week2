using System;

namespace MethodPractice
{
    class Program
    {
        static public void Main(string[] args)
        {
            Program program = new Program();
            program.sarkisozu();

            int kalan = program.kalansayidondur();
            Console.WriteLine(kalan);

            int carp = program.carp(5, 6);
            Console.WriteLine(carp);

            program.isimsoyisim("Serhat", "Uzun");
        }

        public void sarkisozu()
        {
            Console.WriteLine("Uzun ince bir yoldayım gidiyorum gündüz gece");
        }

        public int kalansayidondur()
        {
            Random random = new Random();
            int tamsayi = random.Next(1, 100);
            return tamsayi % 2;
        }

        public int carp(int a, int b)
        {
            return a * b;
        }

        public void isimsoyisim(string isim, string soyisim)
        {
            Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
        }
    }
}