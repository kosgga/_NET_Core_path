// See https://aka.ms/new-console-template for more information
using System;

namespace hatayonetimi
{
    class program
    {
        static void Main(string[] args)
        {
            // try{
            // Console.WriteLine("Bir sayı giriniz :");
            // int sayi=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("girmiş olduğunuz sayı : "+sayi); 
             
            
            // }
            // catch(Exception ex){
            //     Console.WriteLine("Hata : " + ex.Message.ToString());
                

            // }
            // finally{
            //     Console.WriteLine("işlem tamamlandı");



            // }
            try{
                // int a=int.Parse(null);
                int b=int.Parse("text") ;
            }
            catch(ArgumentNullException ex){
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);

            }
            catch(FormatException ex2){
                Console.WriteLine("format uygın değil");
                Console.WriteLine(ex2);
            }
           finally{
               Console.WriteLine("işlem tamamlandı");
           }
        }
    }
}
