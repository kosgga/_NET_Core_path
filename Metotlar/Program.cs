// See https://aka.ms/new-console-template for more informatio
using System;

namespace metotlar
{
    class program
    {
        static void Main(string[] args)
        {
             //erişim belirteci, geri dönüş tipi, metot adı(parametre listesi,argüman)
             //{
                    //komutlar
             //}
             //metot public ise her yerden erişilebilir
             //metot private tanımlanırsa sadece o class içinde çağırılabilir
             //geri dönüş tipi  bu metot bir şey yaptıktan sonra geriye bir şey dönecek mi
             //geri dönüşü olmayan metotlar için void yazıyor olmak gerekiyor.
             //metot adı isimlendirme amaçlı
             //parametre listesi bu metotun iş yaparken hangi parametreler üzerinde deişikli yapacaksa dier adı da argümandır
             //geri dönüş yapmak istiyorsanız return kullanmalısınız
             int a=2;
             int b=3;
             Console.WriteLine(a+b);
             //Static bir class içinden sadece static metotlar erişilebilir
             int sonuc=Topla(a,b);
             Console.WriteLine(sonuc);
             metotlar ornek=new metotlar();
             
             int sonuc2=ornek.toplavearttır(ref a,ref b);
             ornek.ekranayazdir(Convert.ToString(sonuc2));
             ornek.ekranayazdir(Convert.ToString(sonuc));
             ornek.ekranayazdir(Convert.ToString(a+b));

        }
        static int Topla(int deger1, int deger2) 
        {
            return (deger1+deger2);

        }
    }
    class metotlar{
        //erişim belirteci default olarak privatedır.erişilebilir olması için public yazmak lazım
        public void ekranayazdir(string veri)
        {
        Console.WriteLine(veri);
        }
        public int toplavearttır(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
    //Call b y value atama yukarıda yapıldığı gibi
    //birde call by referance var oda sanırım fonksiyon parametrelerinin daha global bir hal almasını sağlayacak

}
