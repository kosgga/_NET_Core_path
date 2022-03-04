// See https://aka.ms/new-console-template for more information
using System;

namespace diziler
{
    class program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler=new string[5];

            string[] hayvanlar={"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi=new int[5];

            //dizilere değer atama ve erişim

            renkler[0]="mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3]=10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı

            //klavyeden girilen n tane sayının ortalamasını alan program
            //dizi oluşturcam bu diziinin boyutuna konsoldan gelen sayı belirlesin

            Console.Write("dizinin eleman sayısını giriniz: ");
            int diziuzunluğu=int.Parse(Console.ReadLine());
            int[] sayidizisi= new int[diziuzunluğu];
            for (int i = 0; i < diziuzunluğu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz ",i+1);
                sayidizisi[i]=int.Parse(Console.ReadLine());
                
            }
            int toplam = 0;

            foreach (var sayi in sayidizisi)
            {
                toplam +=sayi;
                
            }
            Console.WriteLine("Ortalama : "+toplam/diziuzunluğu);

        }
        if (true)
        {
            
        }
    }
    
}