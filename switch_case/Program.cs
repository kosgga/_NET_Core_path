// See https://aka.ms/new-console-template for more information
using System;
namespace case_1
{
    class program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak Ayındasınız");
                break;
                case 2:
                Console.WriteLine("Şubat ayındasınız");
                break;
                case 4:
                Console.WriteLine("Mart ayındasınız");
                break;
                
                default:
                Console.WriteLine("yanlış veri girdiniz");
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahardasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz ayındasınız");
                    break;


                
                default:
                break;
            }
        }
    }
}
