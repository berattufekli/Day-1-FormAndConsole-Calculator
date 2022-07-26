using Calculator;
using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim = int.MaxValue;
            double num1, num2;

            do
            {
                Console.WriteLine("0. Çıkış");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkarma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");

                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Seçim string ifade içermemelidir. Lütfen tekrar deneyiniz.\n");
                    continue;
                }

                switch (secim)
                {
                    case 0:
                        break;
                    
                    case 1:
                        try
                        {
                            Console.WriteLine("\n\nLütfen 1. Sayiyi Giriniz: ");
                            num1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Lütfen 2. Sayiyi Giriniz: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            
                            Console.WriteLine("Sonuç: " + Helper.Plus(num1, num2) + "\n");
                            
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Girilen sayılar boş olamaz veya string ifade içeremez. Lütfen tekrar deneyiniz\n");
                        }
                        break;


                    case 2:
                        try
                        {
                            Console.WriteLine("\n\nLütfen 1. Sayiyi Giriniz: ");
                            num1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Lütfen 2. Sayiyi Giriniz: ");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Sonuç: " + Helper.Minus(num1, num2) + "\n");

                        }
                        catch
                        {
                            Console.WriteLine("Girilen sayılar boş olamaz veye string ifade içeremez. Lütfen tekrar deneyiniz\n");
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("\n\nLütfen 1. Sayiyi Giriniz: ");
                            num1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Lütfen 2. Sayiyi Giriniz: ");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Sonuç: " + Helper.Multiply(num1, num2) + "\n");

                        }
                        catch
                        {
                            Console.WriteLine("Girilen sayılar boş olamaz veye string ifade içeremez. Lütfen tekrar deneyiniz\n");

                        }
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("\n\nLütfen 1. Sayiyi Giriniz: ");
                            num1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Lütfen 2. Sayiyi Giriniz: ");
                            num2 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Sonuç: " + Helper.Divide(num1, num2) + "\n");

                        }
                        catch
                        {
                            Console.WriteLine("Girilen sayılar boş olamaz ve string ifade içeremez. Lütfen tekrar deneyiniz\n");
                        }
                        break;

                    default:
                        Console.WriteLine("Seçim yapılamadı. Lütfen tekrar deneyiniz\n");
                        break;
                }
            }
            while (secim != 0) ;
        }

        private void getNums()
        {

        }
    }
}
