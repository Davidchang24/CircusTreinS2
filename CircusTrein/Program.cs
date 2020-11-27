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
            animals.Add(new Animal("Hamster", AnimalSize.Small, AnimalFood.Herbivore));
            animals.Add(new Animal("Kangeroe", AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("Panda", AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("Aap", AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("Hert", AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("Olifant", AnimalSize.Large, AnimalFood.Herbivore));
            animals.Add(new Animal("Slang", AnimalSize.Small, AnimalFood.Carnivore));

            Train train = new Train();
            train.PutAnimalsInWagon(animals);
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
                    Console.WriteLine(animal.ToString());
                }
            }
        }
    }
}
