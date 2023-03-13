using _04.WildFarm.AbstractClasses;
using _04.WildFarm.ChildClasses;
using System;
using System.Collections.Generic;

namespace _04.WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            List<Animal> jungle = new();


            string[] informationAnimal = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Animal animal = default;
            Food food = default;

            while (informationAnimal[0] != "End")
            {
                if (i % 2 == 0)
                {
                    animal = CreatingAnimal(jungle, informationAnimal);
                }
                else
                {
                    food = CreatingFood(informationAnimal, food);
                    AnimalCheker(informationAnimal, animal, food);
                }
                i++;


                informationAnimal = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in jungle)
            {
                Console.WriteLine(item);
            }
        }

        private static void AnimalCheker(string[] informationAnimal, Animal animal, Food food)
        {
            if (animal is Hen hen)
            {
                Console.WriteLine(hen.Sound());
                hen.Weight += 0.35 * food.Quantity;

                hen.FoodEaten += food.Quantity;
            }


            if (animal is Mouse mouse)
            {
                Console.WriteLine(mouse.Sound());

                if (informationAnimal[0] == "Vegetable" || informationAnimal[0] == "Fruit")
                {
                    mouse.Weight += 0.10 * food.Quantity;

                    mouse.FoodEaten += food.Quantity;
                }
                else
                {
                    Console.WriteLine($"{mouse.GetType().Name} does not eat {informationAnimal[0]}!");
                }
            }


            if (animal is Cat cat)
            {
                Console.WriteLine(cat.Sound());

                if (informationAnimal[0] == "Vegetable" || informationAnimal[0] == "Meat")
                {
                    cat.Weight += 0.30 * food.Quantity;

                    cat.FoodEaten += food.Quantity;
                }
                else
                {
                    Console.WriteLine($"{cat.GetType().Name} does not eat {informationAnimal[0]}!");
                }

            }

            if (animal is Tiger tiger)
            {
                Console.WriteLine(tiger.Sound());

                if (informationAnimal[0] == "Meat")
                {
                    tiger.Weight += 1.00 * food.Quantity;

                    tiger.FoodEaten += food.Quantity;
                }
                else
                {
                    Console.WriteLine($"{tiger.GetType().Name} does not eat {informationAnimal[0]}!");
                }

            }
            if (animal is Dog dog)
            {
                Console.WriteLine(dog.Sound());

                if (informationAnimal[0] == "Meat")
                {
                    dog.Weight += 0.40 * food.Quantity;

                    dog.FoodEaten += food.Quantity;
                }
                else
                {
                    Console.WriteLine($"{dog.GetType().Name} does not eat {informationAnimal[0]}!");
                }
            }
            if (animal is Owl owl)
            {
                Console.WriteLine(owl.Sound());

                if (informationAnimal[0] == "Meat")
                {
                    owl.Weight += 0.25 * food.Quantity;

                    owl.FoodEaten += food.Quantity;
                }
                else
                {
                    Console.WriteLine($"{owl.GetType().Name} does not eat {informationAnimal[0]}!");
                }
            }
        }

        private static Food CreatingFood(string[] informationAnimal, Food food)
        {
            int quantity = int.Parse(informationAnimal[1]);

            if (informationAnimal[0] == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            if (informationAnimal[0] == "Fruit")
            {
                food = new Fruit(quantity);
            }
            if (informationAnimal[0] == "Meat")
            {
                food = new Meat(quantity);
            }
            if (informationAnimal[0] == "Seeds")
            {
                food = new Seeds(quantity);
            }

            return food;
        }

        private static Animal CreatingAnimal(List<Animal> animals, string[] informationAnimal)
        {
            Animal animal = default;
            if (informationAnimal[0] == "Cat")
            {
                animal = new Cat(informationAnimal[1], double.Parse(informationAnimal[2]), 0, informationAnimal[3], informationAnimal[4]);
                animals.Add((Feline)animal);
            }
            if (informationAnimal[0] == "Tiger")
            {
                animal = new Tiger(informationAnimal[1], double.Parse(informationAnimal[2]), 0, informationAnimal[3], informationAnimal[4]);
                animals.Add((Feline)animal);
            }
            if (informationAnimal[0] == "Owl")
            {
                animal = new Owl(informationAnimal[1], double.Parse(informationAnimal[2]), 0, double.Parse(informationAnimal[3]));
                animals.Add((Bird)animal);

            }
            if (informationAnimal[0] == "Hen")
            {
                animal = new Hen(informationAnimal[1], double.Parse(informationAnimal[2]), 0, double.Parse(informationAnimal[3]));
                animals.Add((Bird)animal);
            }
            if (informationAnimal[0] == "Mouse")
            {
                animal = new Mouse(informationAnimal[1], double.Parse(informationAnimal[2]), 0, informationAnimal[3]);
                animals.Add((Pet)animal);
            }
            if (informationAnimal[0] == "Dog")
            {
                animal = new Dog(informationAnimal[1], double.Parse(informationAnimal[2]), 0, informationAnimal[3]);
                animals.Add((Pet)animal);
            }

            return animal;
        }
    }
}
