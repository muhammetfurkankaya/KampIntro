using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int sayi1 = 10;                       
            int sayi2 = 30;                       //int,decimal,float,double,bool(arka planda 0,1 (true,false) tutar) = değer tip
            sayi1 = sayi2;                                 //stock' a atar
            sayi2 = 65;                                  
            Console.WriteLine(sayi1); //30

            int[] sayilar1 = new int[] {10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };       // array,class,interface = referans tip
            sayilar1 = sayilar2;                                     //heap' e atar
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //999
        }
    }
}
