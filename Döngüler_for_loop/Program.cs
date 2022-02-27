// See https://aka.ms/new-console-template for more information
using System;

namespace forloop
{
    class program
    {
        static void Main(string[] args)
        {
            //ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdırma
            Console.Write("Lütfen bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <=sayac; i++)
            {
                //komutlar
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }

                int tek_toplam=0;
                int cift_toplam=0;
                for (int j = 1; j <=1000; j++)
                {
                    if(j%2==1)
                        tek_toplam +=j;
                    else
                        cift_toplam +=j;

                    
                    
                    
                }
                Console.WriteLine("Tek toplam = "+tek_toplam);
                Console.WriteLine("Çift Toplam= "+cift_toplam);

                //break ve continue
                //continue döngü içerisinde belirlenen bir cycle atlamamıza 
                //break ise döngüden çıkmasını istiyorsanız gibi

                for (int l = 0; l < 10; l++)

                {
                    if (l==9)
                        break;
                   

                    if(l==7)
                        continue;
                    Console.WriteLine(l);
                }

                
            }
        }
    }
}
