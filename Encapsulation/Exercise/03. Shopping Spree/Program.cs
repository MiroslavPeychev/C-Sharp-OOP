namespace P04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                var tokens = item.Split("=", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    string name = tokens[0];
                    decimal money = decimal.Parse(tokens[1]);
                    var currentPerson = new Person(name, money);
                    people.Add(currentPerson);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
                
            }

            List<Product> products = new List<Product>();
            string[] secondInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in secondInput)
            {
                var splittedSecondInput = item.Split("=", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    string productName = splittedSecondInput[0];
                    decimal cost = decimal.Parse(splittedSecondInput[1]);
                    var currentProduct = new Product(productName, cost);
                    products.Add(currentProduct);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            while (true)
            {
                string thirdInput = Console.ReadLine();

                if (thirdInput == "END")
                {
                    break;
                }
                string[] tokens = thirdInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = tokens[0];
                string productName = tokens[1];

                var person = people.Single(x => x.Name == personName);
                var product = products.Single(x => x.Name == productName);

                if (person.PersonCanAffortProduct(product)==true)
                {
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
            }

            foreach (var person in people)
            {
                if (person.Products.Count==0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x=>x.Name))}");
                }
            }
        }
    }
}