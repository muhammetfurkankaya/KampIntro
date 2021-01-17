using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel kurs";
            string kurs3 = "java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı",
                "Programlamaya Başlangıç İçin Temel kurs",
                "java","Python","C#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //genelde foreach kullanılır.
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
