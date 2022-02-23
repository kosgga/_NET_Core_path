// See https://aka.ms/new-console-template for more information
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Atama işlemleri");
            //Atama ve işlemli atama işlemleri
            int x =3;
            int y =3;
            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantıksal operatörler
            //||, &&,!
            Console.WriteLine("Mantıksal Operaötrler");
            bool isSuccess=true;
            bool iscompleted=false;
            if(isSuccess && iscompleted)
                Console.WriteLine("Perfect");
            if(isSuccess || iscompleted)
                Console.WriteLine("Great");
            if(isSuccess && !iscompleted)
                Console.WriteLine("Fine");


            //İlişkisel Operatörler
            //< > <= >= != ==
            Console.WriteLine("******İlişkisel Operaötler******");
            int a=3;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik operatörler
            // / * + - 
            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);

            //%Mod almak için kullanılır. Böldükten sonra kalanı getirir

            int sonuc2=20%3;
            Console.WriteLine(sonuc2);
            


        }
    }
}
