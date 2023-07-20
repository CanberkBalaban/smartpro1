using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double kilo, boy, boyunkaresi, sonuc;

            //Console.WriteLine("kilonuzu giriniz");
            //kilo= double.Parse(Console.ReadLine());
            //Console.WriteLine("boyunuzu giriniz");
            //boy= double.Parse(Console.ReadLine());

            //boyunkaresi = boy*boy ;

            //sonuc = kilo / boyunkaresi;

            //Console.WriteLine("Vücut kütle endeksiniz" + (" ") + sonuc);

            #region KOŞUL İFADELERİ 

            /*
             * == EŞİTTİR
             * === DENKTİR
             < KÜÇÜKTÜR
             > BÜYÜKTÜR
             <= KÜÇÜKTÜR VEYA EŞİTTİR
             >= BÜYÜK VEYA EŞİTTİR
             && VE
             || VEYA
             != EŞİT DEĞİLDİR VEYA DENK DEĞİLDİR
             */
            #endregion


            #region IF & ELSE & ELSE IF
            //if(true) //koşul durumu
            //{


            //}

            //else if(true) //else if 1. koşulun yani if'in sağlanmadığı durumda geçerlidir
            //{



            //}

            //else if (true) // 1. ve 2. koşulun sağlanmadığı durumda geçerlidir (yol ayrımı)
            //{




            //}

            //else
            //{

            //    //sonuç yazılır
            //}
            #endregion


            double sayi_1, sayi_2, sonuc;


            Console.WriteLine("Bir sayı giriniz");
            sayi_1= double.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz");
            sayi_2= double.Parse(Console.ReadLine());

            sonuc = sayi_1 + sayi_2;

            if (sonuc > 10)
            {
                Console.WriteLine("Sayı 10'dan büyük"); 
            } 
           





            else if (sonuc < 10)
            {

                Console.WriteLine("Sayınız 10'dan küçük");
            } 

            else {
                Console.WriteLine("Sayınız 10'a eşit");
                    }
            





            Console.ReadKey();
        }
    }
}
