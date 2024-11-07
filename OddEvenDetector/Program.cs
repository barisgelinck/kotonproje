using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OddEvenDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {   
                //Cok pratik gozukmese de dis kaynaklardan cok kod almak istemedigim icin satirlarin birbirine girmesini engellemek icin "  " yazarak cozdum.
                Console.WriteLine("  ");
                Console.WriteLine("Numara değerinizi girin: ");
                Console.WriteLine("  ");
                Console.WriteLine("Eğer çıkmak isterseniz 'exit' yazabilirsiniz.");
                Console.WriteLine("  ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }

                //Girilen deger gercekten sayi mi diye baktigim yer
                if (int.TryParse(input, out int numara))
                {
                    if (numara % 2 == 0)
                    {
                        Console.WriteLine("  ");
                        Console.WriteLine("Girdiğiniz değer çift sayıdır.");
                        Console.WriteLine("  ");
                    }
                    else
                    {
                        Console.WriteLine("  ");
                        Console.WriteLine("Girdiğiniz değer tek sayıdır.");
                        Console.WriteLine("  ");
                    }
                }
                  else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı değeri giriniz.");
                }
            }
            Console.ReadLine();
        }
    }
}
