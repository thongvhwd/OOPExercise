using Exercise4.Models;
using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declare animal array
            var animals = new Animal[]
            {
                new Dog()
                {
                    Name = "Ben",
                    Age = 5,
                    Sex = true
                },
                new Dog()
                {
                    Name = "Na",
                    Age = 6,
                    Sex = false
                },
                new Dog()
                {
                    Name = "Heo",
                    Age = 1,
                    Sex = true
                },
                new Frog()
                {
                    Name = "Super Frog Man",
                    Age = 20,
                    Sex = true
                },
                new Frog()
                {
                    Name = "Wonder Frog Women",
                    Age = 18,
                    Sex = false
                },
                new Cat()
                {
                    Name = "Santiago",
                    Age = 3,
                    Sex = true
                },
                new Cat()
                {
                    Name = "Elizabeth",
                    Age = 2,
                    Sex = false
                },
                new Kitten()
                {
                    Name = "Kitten",
                    Age = 2
                },
                new Tomcat()
                {
                    Name = "Tom",
                    Age = 5
                },
            };
            #endregion
            CalculateAverageAge(animals);
            //Animal sound
            Console.WriteLine("Animal sound----------------------------");            
            foreach (var animal in animals)
            {
                var animalSound = animal.Sound();
                var animalKind = Animal.IdentifyAnimalBySound(animalSound);
                var gender =  animal.Sex ? "male" : "female" ;
                Console.WriteLine($"{animal.Name} sound {animalSound}. It is {animal.Age} years old {gender}, {animalKind}");
            }
            Console.ReadLine();
        }

        static void CalculateAverageAge(Animal[] animals)
        {
            var animalByKindQuery = from animal in animals
                                    group animal by GetAnimalKind(animal)
                                    into animalByKind
                                    orderby animalByKind.Key
                                    select animalByKind;
            foreach (var animalGroup in animalByKindQuery)
            {
                var totalAge = 0.0;
                foreach (var animal in animalGroup)
                {
                    totalAge += animal.Age;
                }
                Console.WriteLine($"Average of {animalGroup.Key} is: {totalAge / animalGroup.Count()}");
            }
            
        }

        static string GetAnimalKind(Animal animal)
        {
            if (animal.GetType().BaseType.Name == typeof(Animal).Name)
            {
                return animal.GetType().Name;
            }
            return animal.GetType().BaseType.Name;
        }
        
    }
}
