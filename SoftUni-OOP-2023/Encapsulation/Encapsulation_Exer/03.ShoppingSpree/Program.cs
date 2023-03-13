using System;
using System.Collections.Generic;


namespace ShoppingSpree
{
    public class Program
    {
              
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> infoOutput = new();
            List<Person> people = new();
            List<Product> product = new();

            string peopleInput = Console.ReadLine();
            string productInput = Console.ReadLine();

            SpliterForPeople(people, peopleInput);
            SpliterForProduct(product, productInput);
            Dictionrer(infoOutput, people);


            string[] input = Console.ReadLine().Split(' ',
             StringSplitOptions.RemoveEmptyEntries);

            bool getOut = false;

            while (input[0] != "END")
            {
                string buyer = input[0];
                string buyingPProoduct = input[1];

                foreach (var p in people)
                {
                    if (buyer == p.Name)
                    {
                        foreach (var pro in product)
                        {
                            if (buyingPProoduct == pro.Name)
                            {
                                if (p.Money - pro.Cost >= 0)
                                {
                                    p.Money -= pro.Cost;

                                    infoOutput[p.Name].Add(pro.Name);

                                    Console.WriteLine($"{p.Name} bought {pro.Name}");

                                }
                                else
                                {
                                    Console.WriteLine($"{p.Name} can't afford {pro.Name}");
                                }
                                getOut = true;
                                break;
                            }
                        }
                        if (getOut)
                        {
                            getOut = false;
                            break;
                        }
                    }
                }

                input = Console.ReadLine().Split(' ',
              StringSplitOptions.RemoveEmptyEntries);
            }


            foreach (var item in infoOutput)
            {
                if (item.Value.Count == 0)
                {
                    Console.WriteLine($"{item.Key} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
                }


            }




        }

        private static void SpliterForPeople(List<Person> people, string peopleInput)
        {
            if (!peopleInput.Contains(';'))
            {
                string[] peopleSplitedInput = peopleInput.Split('=',
                    StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    Person person = new Person(peopleSplitedInput[0], double.Parse(peopleSplitedInput[1]));

                    people.Add(person);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }

            }
            else if (peopleInput.Contains(';'))
            {
                string[] peopleSplitedInput = peopleInput.Trim().Split(';',
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var nameAndMoney in peopleSplitedInput)
                {
                    string[] current = nameAndMoney.Trim().Split('=');

                    try
                    {
                        Person person = new Person(current[0], double.Parse(current[1]));

                        people.Add(person);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }



                }


            }
        }

        static void Dictionrer(Dictionary<string, List<string>> current, List<Person> people)
        {
            foreach (var name in people)
            {
                if (!current.ContainsKey(name.Name))
                {
                    current.Add(name.Name, new List<string>());
                }
            }
        }
        private static void SpliterForProduct(List<Product> products, string productInput)
        {
            if (!productInput.Contains(';'))
            {
                string[] peopleSplitedInput = productInput.Split('=',
                    StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    Product product = new Product(peopleSplitedInput[0], double.Parse(peopleSplitedInput[1]));

                    products.Add(product);

                }
                catch (Exception edx)
                {

                    Console.WriteLine(edx.Message);
                    Environment.Exit(0);
                }

            }
            else if (productInput.Contains(';'))
            {
                string[] peopleSplitedInput = productInput.Trim().Split(';',
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (var nameAndMoney in peopleSplitedInput)
                {
                    string[] current = nameAndMoney.Trim().Split('=');
                    try
                    {
                        Product product = new Product(current[0], double.Parse(current[1]));

                        products.Add(product);

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                        Environment.Exit(0);
                    }


                }


            }
        }
    }
}
