namespace _03_Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static List<Dog> dogs = new List<Dog>();
        public static List<Cat> cats = new List<Cat>();
        public static List<Snake> snakes = new List<Snake>();

        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input
                                  .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 2)
                {
                    string theClass = tokens[0];

                    switch (theClass)
                    {
                        case "Dog":
                            
                                AddingDogs(tokens);
                                break;
                         
                        case "Cat":
                         
                                AddingCats(tokens);
                                break;
                         
                        case "Snake":
                         
                                AddingSnakes(tokens);
                                break;
                         
                    }
                }
                else
                {
                    string name = tokens[1];

                    MakeSound(name);
                }

                input = Console.ReadLine();
            }

            Print();
        }

        static void Print()
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.InteligenceQuotient}");
            }
            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        static void MakeSound(string name)
        {
            foreach (var dog in dogs)
            {
                if (dog.Name == name)
                {
                    Dog.ProduceSound();
                    break;
                }
            }
            foreach (var cat in cats)
            {
                if (cat.Name == name)
                {
                    Cat.ProduceSound();
                    break;
                }
            }
            foreach (var snake in snakes)
            {
                if (snake.Name == name)
                {
                    Snake.ProduceSound();
                    break;
                }
            }

        }

        static void AddingSnakes(string[] tokens)
        {
            string name = tokens[1];
            int age = int.Parse(tokens[2]);
            int specificity = int.Parse(tokens[3]);

            Snake newSnake = new Snake
            {
                Name = name,
                Age = age,
                CrueltyCoefficient = specificity
            };
            snakes.Add(newSnake);
        }

        static void AddingCats(string[] tokens)
        {
            string name = tokens[1];
            int age = int.Parse(tokens[2]);
            int specificity = int.Parse(tokens[3]);

            Cat newCat = new Cat
            {
                Name = name,
                Age = age,
                InteligenceQuotient = specificity
            };
            cats.Add(newCat);
        }

        static void AddingDogs(string[] tokens)
        {
            string name = tokens[1];
            int age = int.Parse(tokens[2]);
            int specificity = int.Parse(tokens[3]);

            Dog newDog = new Dog
            {
                Name = name,
                Age = age,
                NumberOfLegs = specificity
            };
            dogs.Add(newDog);
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int InteligenceQuotient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
    public class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
}
