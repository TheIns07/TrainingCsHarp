using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingC_
{
    public class CollectionsExample
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Model = "Honda",
                Make = "2000"
            };

            Book book = new Book
            {
                Author = "Author",
                ISBN = "ISBN",
                Name = "Name"
            };

            Car car1 = new Car
            {
                Model = "Honda",
                Make = "2000"
            };

            Book book1 = new Book
            {
                Author = "Jose",
                ISBN = "ISBN",
                Name = "Name"
            };
            Dictionary<string, Book> myDictionary = new Dictionary<string, Book>();
            myDictionary.Add(book.Author, book);
            myDictionary.Add(book1.Author, book1);

            List<Car> listCars = new List<Car> { 
                new Car{ Make = "12321", Model = "BWM", Year=2024},
                new Car {Make = "2TGE4", Model = "FORD", Year=2021},
                new Car{ Make = "12321", Model = "BWM", Year = 2022}

            };

            //LINQ Query
            var orderedCars = from myCar in listCars 
                              orderby myCar.Year ascending
                              select myCar;
            //LINQ Method
            var bmws = listCars.Where(p => p.Model == "BWM" && p.Make == "12321").OrderByDescending(p=> p.Year);

            //Boolean Comprobation
            Console.WriteLine(listCars.TrueForAll(p => p.Year > 2020));

            foreach (var carrito in listCars)
            {
                Console.WriteLine("{0} {1}", carrito.Year, carrito.Model, carrito.Make);
            }
            Console.ReadLine();



        }

        class Car
        {
            public string Model { get; set; }
            public string Make { get; set; }
            public int Year { get; set; }

        }

        class Book
        {
            public string Name { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
