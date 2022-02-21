// See https://aka.ms/new-console-template for more information
using System;
namespace Variables
{
    class Variables{
        static void Main(string[] args)
        {
            int deger;
            deger = 2;
            string degisken = null;
            string Degisken = null;
            Console.WriteLine(deger);
            byte b=5;//0-255(1byte)
            sbyte c=5;//-128-128(1byte)
            short s=5;//-32768_32768(2byte)
            ushort us=5;//0_65365(2 byte) integer

            Int16 i16=2;  //2byte 
            int  i=2; //4byte
            Int32 i32=4;//4byte
            Int64 i64=4;//8byte

            uint ui=2; //4 byte
            long l=2; //8byte
            ulong ul=2;//8 bute positive
//REAL NUMBERS
            float f=5;  //4byte 
            double d=5; //8 byte reel 
            decimal dec=5; //16 byte

            char ch='2'; //2byte
            string st="Jayjay";//Unlimited

            bool bl=true; 
            bool blf=false;

            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);

            object o1="x";
            object o2='y';
            object o3=3;
            object o4=3.4;

            string s_2="";//null
            string s_3=null;//null
            string str3=string.Empty;//null
            string ad="Jayjay";
            string soyad="Delly";
            string tamisim =ad +" "+ soyad;

            int intefer1 =5;
            int intefer2=3;
            int intefer3=intefer1*intefer2;
            // Değişken dönüşümleri

            string str20="20";
            int int20=20;
            string yenideger=str20+int20.ToString();
            Console.WriteLine(yenideger);
            int int30=int20+Convert.ToInt32(str20);
            Console.WriteLine(int30);

            //parse

            int int42=int20+int.Parse(str20);

             int degisken = 5;
   string degisken = "merhaba";
   Console.WriteLine(degisken);





        }
    }
}

