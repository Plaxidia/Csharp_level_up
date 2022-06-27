using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{   //1.User can purchase from n iteam the online store
    //2.Each item  must be displayed for the user to choose 
    //3.Each item will contain a  title and price 
    //4.Each item must also contain unique properties
    class Program
    {
        static void Main(string[] args)
        {

            Welcome();
            PurchaseItem();

        }
        static void Welcome()
        {
            Console.WriteLine("Welcome to our store! Here are the iteams you can buy ");
            Console.WriteLine("Book");
            Console.WriteLine("Shirt");
            Console.WriteLine("Shoes");
            Console.WriteLine("What would you like to buy");

        }
        static void PurchaseItem()
        {
            var item = Console.ReadLine();
          
                switch (item)
            {

                case "Book":
                    {
                        var book = new Book();
                        book.Author = "Plaxidia Hove";
                        book.Title = " The wizard of codding";
                        book.Price = 9.99;
                        Console.WriteLine($"You have purchases a { book.Title} " + $"{  book.Author}  for { book.Price}");
                        break;
                    }
                case "Shirt":
                    {
                        var shirt = new Shirt();
                        shirt.size = "s";
                        shirt.Price = 80.01;
                        shirt.Title = "sports";
                        Console.WriteLine($"You have purchases a {shirt.Title}" + $"{ shirt.size}  for {shirt.Price}");
                        break;
                    }
                case "Shoes":
                    {
                        var shoes = new Shoes();
                        shoes.Price = 190;
                        shoes.Title = "sports";
                        shoes.color = " blue";
                        Console.WriteLine($"You have purchased a {shoes.Title}" + $"{ shoes.color}  for {shoes.Price}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("We do not have the product you have entered please check the spelling");
                        break;
                    }
            }

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine(" Do you want buy again?");
                string isRunningResponse = Console.ReadLine();
                if (isRunningResponse == "no")
                {
                    isRunning = false;
                }

            }

        }

        class Store
        {
            public string Title { get; set; }
            public double Price { get; set; }


        }
        class Book : Store
        {
            public string Author { get; set; }

        }
        class Shirt : Store
        {
            public string size { get; set; }

        }
        class Shoes : Store
        {
            public string color { get; set; }
        }
    }
    
}
