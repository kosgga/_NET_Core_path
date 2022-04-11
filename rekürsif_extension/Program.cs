// See https://aka.ms/new-console-template for more information
using System;

namespace rekürsif_extension
{
    class program
    {
        static void Main(string[] args)
        {
            //rekürsif öz yinelemeli program
            //3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result=result*3;
                
            }
            Console.WriteLine(result);
            islemler instance=new();
            Console.WriteLine(instance.Expo(3,4));
            // Extension metotlar
            string ifade ="Jayjay Delly Jose";
            bool sonuc=ifade.Checkspaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
               Console.WriteLine(ifade.RWS());
                
            }
            Console.WriteLine(ifade.Makeuppercase());
            Console.WriteLine(ifade.makelowercase());
            int[] dizi ={9,3,6,2,1,5,0};
            dizi.sortarray();
            dizi.ekranayazdir();
            int sayi = 5;
            Console.WriteLine(sayi.iseven());
            Console.WriteLine(ifade.getfirstchar());
            
        }
    }
    public class islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs<2)
            {
                return sayi;
            }
            return Expo(sayi,üs-1)*sayi;

        }
        //Expo(3,4)
        //Expo(3,3)*3
        //expo(3,2)*3*3
        //expo(3,1)*3*3*3
        //3*3*3*3
    }
    //extension classlar ve extension metotlar statik olmalı
    //this ifadesini eklerseniz artık bu extension metottur
    public static class extensions
    {
        public static bool Checkspaces(this string param)
        {
            return param.Contains(" ");
        }
    

    public static string RWS(this string param)
    {
        string[] dizi =param.Split(" ");
        return string.Join("",dizi);
    }
    public static string Makeuppercase(this string param)
    {
        return param.ToUpper();
    }
    public static string makelowercase(this string param)
    {
        return param.ToLower();
    }
    public static int[] sortarray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void ekranayazdir(this int[] param)
    {
        foreach (int  item in param)
        {
            Console.WriteLine(item);
            
        }
    }
    public static bool iseven(this int param)
    {
        return param%2==0;
    }
    public static string getfirstchar(this string param)
    {
        return param.Substring(0,1);
    }
    }
}
