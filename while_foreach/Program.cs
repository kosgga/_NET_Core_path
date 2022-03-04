// See https://aka.ms/new-console-template for more information

using System;

namespace while_for
{
    class program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayarak konsoldan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp konsola yazdıran program
            Console.Write("ortalamasını almak istediğiniz sayıyı giriniz");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int total=0;
            while (sayac<=sayi)
            {
                total+=sayac;
                sayac ++;

            }
            Console.WriteLine(total/sayi);
            // adan zye kadar tüm harfleri konsola yazdıralım
            char character='a';
            while (character<'z')
            {
                Console.Write(character);
                character ++;
                
            }
            //for each 

            string[] arabalar ={"BMW", "Ford", "Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);

                
            }
        }
    }

    
}