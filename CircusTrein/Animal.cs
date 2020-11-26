using System;
namespace CircusTrein
{
    public class Animal
    {
        public AnimalSize AnimalSize { get; set; }
        public AnimalFood AnimalFood { get; set; }


        public Animal(AnimalSize animalSize, AnimalFood animalFood)
        {
            AnimalSize = animalSize;
            AnimalFood = animalFood;
        }

        public bool IsAnimalThreat(Animal animal)
        {
            if (animal.AnimalFood == AnimalFood.Carnivore && animal.AnimalSize >= AnimalSize || AnimalFood == AnimalFood.Carnivore && animal.AnimalSize <= AnimalSize)
                return true;
            return false;
        }
    }
    public enum AnimalSize
    {
        Small = 1,
        Medium = 3,
        Large = 5
    }

    public enum AnimalFood
    {
        Carnivore = 'm',
        Herbivore = 'p',
    }
}
