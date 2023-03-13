using System;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] animalInfo = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);

                
                try
                {
                    Console.WriteLine(animalType);
                    switch (animalType)
                    {
                        case "Dog":
                            Dog dog = new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);

                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Cat":
                            Cat cat = new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]);
                            Console.WriteLine(cat);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(animalInfo[0], int.Parse(animalInfo[1]));

                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(animalInfo[0], int.Parse(animalInfo[1]));

                            Console.WriteLine(tomcat);
                            break;
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                

            }

        }


    }
}

