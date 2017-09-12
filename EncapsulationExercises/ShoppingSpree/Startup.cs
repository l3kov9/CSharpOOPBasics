using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Startup
    {
        public static void Main()
        {
            try
            {
                var people = new List<Person>();
                var tokens = Console.ReadLine()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var person in tokens)
                {

                    var personInfo = person
                        .Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    people.Add(new Person(personInfo[0], decimal.Parse(personInfo[1])));

                }

                var products = new List<Product>();
                var productTokens = Console.ReadLine()
                    .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var product in productTokens)
                {
                    try
                    {
                        var productInfo = product
                            .Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                        products.Add(new Product(productInfo[0], decimal.Parse(productInfo[1])));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                while (true)
                {
                    var command = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (command[0].Equals("END"))
                    {
                        break;
                    }

                    var name = command[0];
                    var product = command[1];

                    Console.WriteLine(people.FirstOrDefault(p => p.Name == name)
                        .BuyProduct(products.FirstOrDefault(p => p.Name == product))
                        ? $"{name} bought {product}"
                        : $"{name} can't afford {product}.");
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person.Products.Count > 0
                        ? $"{person.Name} - {string.Join(", ", person.Products.Select(x => x.Name))}"
                        : $"{person.Name} - nothing bought.");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
