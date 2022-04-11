using System;

namespace metotlar_overloading
{
    class program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="999";

            bool sonuc=int.TryParse(sayi, out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);

            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Metotlar instance=new Metotlar();
            instance.Topla(2,3,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);
            

            //Metot overlaoding(aşırı yükleme)
            int ifade=999;
            //instance.Ekranayazdir(Convert.ToString(ifade)); string veri tipi beklediği için
            instance.Ekranayazdir(ifade);
            //hangisine çağıracağına metot imzası ile karar veriyor
            //Metot imzası
            //metotadi+parametre sayisi+parametre tipi
            instance.Ekranayazdir("jayjay","Delly");


        }
    }
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam=a+b;
        }
        public void Ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        
        //metot overloading yaparak birden fazla veri tipi ile çalışabildik
        public void Ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void Ekranayazdir(string veri, string veri2)
        {
        }
    }
}