using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlr.dstnApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------FOR--------------------------------
            //-------------------
            //------------2 sayı arasındaki sayılar---------------

            //Console.Write("1. Sayıyı girin:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı girin:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //Console.WriteLine("bir sayı giriniz");
            //int sayi, sayac = 0;
            //sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;

            //    }
            //}
            //if (sayac == 0)
            //{
            //    Console.WriteLine("Sayı Asal");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Asal Değil");

            //}
            //Console.ReadKey();

            //ASAL SAYI
            Console.WriteLine("bir sayı giriniz");
            int sayi, sayac = 0;

            sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    if (sayac == 1)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sayac == 0 ? "asal" : "asal değil");
            Console.ReadKey();


            //-----------2 ve 4 e tam bölünen sayılar 100 e kadar------------

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 == 0 && i % 4 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadKey();





            ////------2 sayı arasındaki 4 e tam bölünen sayılar------
            //Console.Write("1. Sayıyı girin:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. Sayıyı girin:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    if (i % 4 == 0)
            //        Console.WriteLine(i);
            //}
            //Console.ReadKey();

            /*
             Taban ve Kuvveti girilen sayının değerini hesaplama
              Örn: taban:2 üs:5 girildiğinde sonuc=32 yazıdıran program. 
            */
            //int taban, us, sonuc = 1;
            //Console.WriteLine("Taban sayısını giriniz:");
            //taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kuvvet sayısını giriniz:");
            //us = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= us; i++)
            //{
            //    sonuc = sonuc * taban;
            //}

            //Console.WriteLine("sayının değeri:" + sonuc);

            //Console.ReadLine();
            //Console.ReadKey();


            //"Klavyeden girilen 5 adet sayının en büyüğünü bulan program
            //int sayi, enbuyuk = 0;
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("{0} inci sayi giriniz",i);
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (i == 0)
            //        enbuyuk = sayi;
            //    if (sayi > enbuyuk) //eğer ssayı en büyüktenbbüyükse devreye girer
            //        enbuyuk = sayi;

            //}
            //Console.WriteLine("En buyuk sayi:"+ enbuyuk);
            //Console.ReadKey();



            //---Klavyeden Girilen 10 sayının toplamı--

            //int sayi;
            //int toplam = 0;

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("{0}. inci Sayi giriniz", i);
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + sayi;
            //}
            //Console.WriteLine(" Sayilarin Toplami:"+ toplam);
            //Console.ReadKey();


            //--------------WHİLE------------------
            //1 den 10 akadar sayaıları yaz
            //int sayi = 1;
            //while (sayi <= 10)   
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //Console.ReadKey();



            //-------kullanıcı negatif sayı girene kadar girdiği sayıların toplamını ekrana yazdırınız.
            //int sayi, toplam = 0;
            //while (true)
            //{

            //    Console.Write("Bir sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi < 0)
            //    {
            //        break;
            //    }
            //    toplam += sayi;
            //}
            //Console.WriteLine("Girdiniz sayıların Toplamı = {0}", toplam);
            //Console.ReadKey();

            //----girilen sayıları toplar,0girilince sonlandırır-------
            //int sayi, toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi==0)
            //    {
            //        break;
            //    }
            //    toplam += sayi;

            //}
            //Console.WriteLine("girilen sayıların toplamı:"+toplam);
            //Console.ReadKey();

            //------Kullanıcı 0(sıfır) girene kadar kullanıncın girdiği sayıyı ekrana yazan program-------
            //int sayi = 1;
            //while (true)
            //{
            //    Console.Write("Bir sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Girdiğiniz sayı:" + sayi);


            //    if (sayi==0)
            //    {
            //        break;
            //    }


            //    Console.ReadKey();
            //}

            //-----Kullanıcı 0 girene kadar girdiği çift sayıların sayısını ekrana yazdıran program-----------
            //int sayi, sayac = 0;
            //while (true)
            //{
            //    Console.Write("Bir sayıyı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0)
            //    {
            //       
            //        break;
            //    }
            //    else if (sayi % 2 == 0)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine(sayac + " adet çift sayı girdiniz");
            //Console.ReadKey();
        }
    }
}
