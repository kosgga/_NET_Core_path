// See https://aka.ms/new-console-template for more information

using System;

namespace array_sınıfı
{
    class program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayidizisi={23,12,4,86,72,3,11,7};
            Console.WriteLine("Sırasız liste dizi");
            foreach(var item in sayidizisi)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Sıralı dizi listesi: ");
            Array.Sort(sayidizisi);
            //void fonksiyon
            foreach(var a in sayidizisi)
            {
                Console.WriteLine(a);
            }

            //Clear
            //dizi içerisinde verdiğiniz indexten başlayarak verdiğimiz eleman sayısı kadarını sıfırlıyor
            Console.WriteLine("Array Clear : ");
            Array.Clear(sayidizisi,2,2);
            foreach(var b in sayidizisi){
                Console.WriteLine(b);
            }

            //Reverse
            //Verdiğimiz diziyi ortadan itibaren aynalıyormuş gibi yer değiştiriyor
            Console.WriteLine("reverse_metotu : ");
            Array.Reverse(sayidizisi);
            foreach(var c in sayidizisi){
                Console.WriteLine(c);
            }

            //IndexOf
            //Verdiğimiz dizi içinde verdiğimiz elemanın içerisinde varsa indexini döner
            Console.WriteLine("IndexOf Uygulaması : ");
            Console.WriteLine(Array.IndexOf(sayidizisi,23));
            Array.as

            //Resize 
            //Yeniden boyutlandırma yapıyor
            Console.WriteLine("Resize uygulaması : ");
            Array.Resize<int>(ref sayidizisi,9);
            sayidizisi[8]=99;
            foreach(var d in sayidizisi){
                Console.WriteLine(d);
            }

        }
        
    }
    
}
