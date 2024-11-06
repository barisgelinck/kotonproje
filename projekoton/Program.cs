using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Proje.Customer { FirstName = "Barış" });

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();



            //    Console.ReadLine();
            //}  
            //Console.WriteLine("Hello World"); 
            //Console.ReadLine();

            //int number1 = 10;
            //Console.WriteLine("number1 is {0}", number1);
            //Console.ReadLine(); 


            //double number5 = 10.4;
            //decimal number6 = 10;
            //char character = 'A';
            //bool condition = false;
            //byte number4 = 255;
            //short number3 = 32767;
            //int number1 = 2147483647;
            //long number2 = 92232828378243;


            //Console.WriteLine("Number1 is {0}", number1);
            //Console.WriteLine("Number2 is {0}", number2);
            //Console.WriteLine("Number3 is {0}", number3);
            //Console.WriteLine("Number4 is {0}", number4);
            //Console.WriteLine("Number5 is {0}", number5);
            //Console.WriteLine("Character is : {0}", (int)character);
            //Console.WriteLine((int)Days.Friday);
            //Console.ReadLine();

            //var number = 20;
            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}
            //string[] students = new string[3] { "Baris", "Umut", "Murat" };
            //string[] students2 = { "Baris", "Umut", "Murat" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //    Console.ReadLine();

            //        Array.Resize(ref students2, 4);
            //        students2[3] = "Ali";

            //        foreach (var student in students2)
            //        {
            //            Console.WriteLine(student);
            //        }
            //        string[,] regions = new string[5, 3]
            //        {
            //        { "İstanbul", "İzmit", "Balıkesir" },
            //        { "Ankara", "Konya", "Kirikkale" },
            //        { "Antalya", "Adana", "Mersin" },
            //        { "Rize", "Trabzon", "Samsun" },
            //        { "İzmir", "Muğla", "Manisa" }
            //        };


            //        for (int i = 0; i < regions.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < regions.GetLength(1); j++)
            //            {
            //                Console.Write(regions[i, j] + " ");
            //            }
            //            Console.WriteLine();

            //string sentence = "My full name is Baris Gelincik";

            //var result = sentence.Length;
            //var result2 = sentence.Clone();
            //sentence = "My full name is Umut Kocak";

            //bool result3 = sentence.EndsWith("k");   
            //bool result4 = sentence.StartsWith("My fullname is");
            //var result5 = sentence.IndexOf("name");
            //var result6 = sentence.IndexOf(" ");
            //var result7 = sentence.LastIndexOf(" ");
            //var result8 = sentence.Insert(0, "Hello, ");
            //var result9 = sentence.Substring(3, 4);
            //var result10 = sentence.ToLower(); 
            //var result11 = sentence.ToUpper();
            //var result12 = sentence.Replace("name", "adım");
            //var result13 = sentence.Remove(2, 5);

            //Console.WriteLine(result13);
            //Console.ReadLine();

            //    class CustomerManager 
            //{ 
            //    public void Add()
            //    {
            //        Console.WriteLine("Customer Added.");
            //            }
            //deneme
            //    public void Update()
            //    {
            //        Console.WriteLine("Customer Updated!");
            //        Console.ReadLine();
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Adress { get; set; }

        }
    }

    class Student : Iperson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}








//


//enum Days
//{
//    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
//}
