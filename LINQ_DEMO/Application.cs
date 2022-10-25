using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DEMO
{
    internal class Application
    {
        public void Lab1()
        {
            string[] bilar = { "Volvo", "BMW", "Audi", "Skoda", "Toyota", "Ford", "Mercedes", "Seat", "Honda",
                "Volkswagen", "Opel", "Mazda", "Suzuki" };

            string bil1 = bilar.FirstOrDefault(b => b == "Opel");

            Console.WriteLine(bil1);

            var bilarOnV = bilar.Where(namn => namn.ToUpper().StartsWith("V"));

            Console.WriteLine(bilarOnV);

            var bilarMedDa = bilar.Where(namn => namn.ToUpper().Contains("DA"));

            Console.WriteLine(bilarMedDa);

            var bilarMedXX = bilar.Where(namn => namn.ToUpper().StartsWith("M") || 
                                                 namn.ToUpper().EndsWith("I"));

            foreach (var b in bilarMedXX)
            {
                Console.WriteLine(b);
            }

        }
        public void Lab2()
        {
            
        }






        public void Run()
        {

            Lab1();

            //var allProducts = new List<Product>();
            //var p = new Product();

            //allProducts.Add(new Product { Color = "blue", Name = "penna", Price = 10m });
            //allProducts.Add(new Product { Color = "red", Name = "phone", Price = 500m });
            //allProducts.Add(new Product { Color = "green", Name = "penna", Price = 20m });

            //var productsToShow = new List<Product>();

            //foreach (var item in allProducts)
            //{
            //    if (item.Price < 100)
            //    {
            //        productsToShow.Add(item);
            //    }
            //}

            //foreach (var item in productsToShow)
            //{
            //    Console.WriteLine($"{item.Name} {item.Price} {item.Color}");
            //}


            //var prodList = allProducts.Where(p => p.Price < 100).OrderBy(p => p.Price);

            //foreach (var product in prodList)
            //{
            //    Console.WriteLine(p.Name);
            //}

        }

    }
}
