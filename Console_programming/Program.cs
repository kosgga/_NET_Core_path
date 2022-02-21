// See https://aka.ms/new-console-template for more information
using System;
namespace Console_programming
{
    class Console_programming
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("İsminizi girin");
            string name=Console.ReadLine();
            Console.WriteLine("Soyisminizi girin");
            string surname=Console.ReadLine();

            Console.WriteLine("Merhaba" + name +" "+surname);
        }
    }
    
}

