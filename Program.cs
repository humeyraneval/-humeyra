using System;

namespace hata_ayıklama
{
    class Program
    {
        static void Main(string[] args)
        {
           /* try
            {
              Console.WriteLine("Lütfen bir sayı giriniz.");
              int a = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Girdiğiniz sayı:" + a);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Yanlış bir ifade girdiniz.");
                Console.WriteLine("Hata:" + ex);
             
            }*/
            try
            {
                //int a = int.Parse(null);
                int a = int.Parse("kırmızı");

            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine("hata:" + ex);
            }   
            catch(FormatException ex)
            {
                Console.WriteLine("Yanlı fortmatta bir değer girdinzi.");
                Console.WriteLine("hata:" + ex);

            }
        
        }
    }
}
