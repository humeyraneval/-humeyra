using System;

namespace foor_loop
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            //Ekrana girilen sayıya kadar olan tek sayıları yazdırma.
            /*  Console.WriteLine("Lütfen bira sayı giriniz:");
              int sayac =int.Parse(Console.ReadLine());
              for (int i = 1; i <= sayac; i++)
              {

                  if(i % 2 ==1)
                  Console.WriteLine(i);
              }

              //1'den 1000'e kadar olan tek ve çift sayıların toplamı 
              int tekToplam = 0;
              int cifttoplam = 0;
              for (int i = 1; i <= 1000; i++)
              {
                  if(i % 2 == 1)
                    tekToplam += i; //tekToplam = tekToplam + i;
                  else
                    cifttoplam += i; //ciftToplam = ciftToplam +i;  
              }
              Console.WriteLine("TekToplam: " + tekToplam);
              Console.WriteLine("ÇİftToplam: " + cifttoplam);*/
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
} 
