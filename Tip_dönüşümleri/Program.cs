// See https://aka.ms/new-console-template for more information
using System;

namespace tip_donusunleri{
    class program
    {
        static public void Main(string[] args)
        {
            //Implicit Conversion(Bilinçsiz Dönüşüm)
            //Düşük kapasiteli bir değişkenin kendinden daha büyük başka bir değişkene dönüşmesi işlemi

            byte a=5;//8bit
            sbyte b=30;//8bit/negativeto positive
            short c=10;//16bit/negativetopositiv
            
//int 4 byte negative to positive
            int d=a+b+c;

            Console.WriteLine("d: "+d);

            long h=d;
            Console.WriteLine("long :"+h);
//long 8 byte negative to positive


            float i=h;
            Console.WriteLine("float : "+i);

            //float 4 byte  

            string e="jayjay";
            char f ='k';
            object g=e+f+d;
            Console.WriteLine("object :"+g);

            //Explicit Conversion(Bilinçli Dönüşüm)
            int x=4;
            byte y=(byte)x;
            Console.WriteLine("y : "+y);

            int z=100;
            byte t =(byte)z;
            Console.WriteLine("t : "+t);

            float w=10.3f;
            byte v=(byte)w;
            Console.WriteLine("v : "+w);

            //çevrimlerde veri kaybı olabilir

            Console.WriteLine("****String methods****");
            int xx=6;
            string yy=xx.ToString();
            Console.WriteLine("yy : "+yy);

            string zz=12.5f.ToString();
            Console.WriteLine("zz : "+zz);

            //System.Convert

            Console.WriteLine("****System.Convert****");
            string s1="10",s2="20";
            int sayi1, sayi2;
            int toplam;

            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);

            toplam=sayi1+sayi2;
            Console.WriteLine("Toplam : "+toplam);

            //Parse
            Console.WriteLine("****Parse****");
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin1="10";
            string metin2="10,25";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            double1=Double.Parse(metin2);
            //parse string ifadeleri dönüştürmek için kullanılır.string bir değişkeni parse kullanarak integer bir değere dönüştürüldü
            Console.WriteLine("rakam1 : "+rakam1);
            Console.WriteLine("double1 : "+double1);

        }
    }
}