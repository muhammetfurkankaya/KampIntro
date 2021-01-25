using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int,string> cities = new MyList<int,string>();
            cities.Add(06,"Ankara");
            cities.Add(34,"İstanbul");
            cities.Add(23,"Elazığ");
            cities.Add(01,"Adana");

            Console.WriteLine(cities.Count);

        }


    }
    

}

    

