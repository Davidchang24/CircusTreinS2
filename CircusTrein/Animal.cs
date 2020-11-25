using System;
namespace CircusTrein
{
    public class Animal
    {
        public string AnimalName { get; set; }
        public AnimalSize AnimalSize { get; set; }
        public AnimalFood AnimalFood { get; set; }


        public Animal(string AnimalName, AnimalSize animalSize, AnimalFood animalFood)
        {
            this.AnimalName = AnimalName;
            AnimalSize = animalSize;
            AnimalFood = animalFood;
        }

        public bool IsAnimalDangerous(Animal animal)
        {
            if (animal.AnimalFood == AnimalFood.Carnivore && animal.AnimalSize >= animal.AnimalSize ||
                animal.AnimalFood == AnimalFood.Carnivore && animal.AnimalSize <= animal.AnimalSize)
                return true;
            else
                return false;
        }
    }
    public enum AnimalSize
    {
        Small = 1,
        Medium = 2,
        Large = 3
    }

    public enum AnimalFood
    {
        Carnivore = 'm',
        Herbivore = 'p',
    }
}
