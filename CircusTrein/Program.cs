using System;
using System.Collections.Generic;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Eekhorn", AnimalSize.Small, AnimalFood.Herbivore));
            animals.Add(new Animal("Vogel", AnimalSize.Small, AnimalFood.Herbivore));
            animals.Add(new Animal("Aap", AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("Kalf",AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("Struisvogel", AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("Hert",AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("Olifant",AnimalSize.Large, AnimalFood.Herbivore));
            animals.Add(new Animal("Slang", AnimalSize.Small, AnimalFood.Carnivore));

            Train train = new Train();
            train.PutAnimalsInTrain(animals);
            PrintWagons(train);
        }

        public static void PrintWagons(Train train)
        {
            IReadOnlyList<Wagon> wagons = train.GetWagons();

            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine("---------------------------------------------");
                foreach (Animal animal in wagon.GetAnimals())
                {
                    Console.WriteLine(animal.AnimalName + " " + animal.AnimalFood + " "  +  animal.AnimalSize);
                }
            }
        }
    }
}
