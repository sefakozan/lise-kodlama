using System;
using System.Linq.Expressions;

namespace UcgenKenarBagintisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = SayiAl("a");
            int b = SayiAl("b");
            int c = SayiAl("c");

            // düzgün girilen sayıların üçgen olabileceğini hesaplayan fonksiyon
            KenarKontrolEt(a, b, c);

            // bitti
            Console.WriteLine("End.. Press a key.");
            Console.ReadKey();
        }

        /// <summary>
        /// -kullanıcıdan alacağı kenarın adını yazar
        /// -kullanıcıdan geçerli bir değer alır
        /// </summary>
        /// <param name="kenarAdi">üçgenin bir kenarının adı a, b, c alabilir</param>
        /// <returns>kenarın uzunluğu</returns>
        static int SayiAl(string kenarAdi)
        {
            int num = 0;
            bool kontrolDegeri;

            // Döngüde break ve continue kullanmamaya çalış!
            do
            {
                kontrolDegeri = true;
                try
                {
                    Console.Write($"{kenarAdi} kenarını giriniz: ");
                    string numStr = Console.ReadLine();
                    num = Convert.ToInt32(numStr);

                    if (num <= 0)
                    {
                        throw new Exception("Kenar uzunlugu pozitif sayı olmak zorunda");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // harf girmiş veya pozitif bir sayı girmemiş ise hata yakalar
                    Console.WriteLine("geçerli bir pozitif sayı giriniz!");
                    kontrolDegeri = false;
                }
            } while (kontrolDegeri == false);

            return num;
        }

        static void KenarKontrolEt(int a, int b, int c)
        {
            if (Math.Abs(b - c) < a & a < b + c)
            {
                Console.WriteLine($"kenar uzunlukları {a}, {b}, {c} olan üçgen çizilebilir :)");
            }
            else
            {
                Console.WriteLine($"kenar uzunlukları {a}, {b}, {c} olan üçgen çizilemez :(");
            }
        }
    }
}
