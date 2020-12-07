using System;

namespace CircusTrein
{
    public enum AnimalSize
    {
        Small = 1,
        Medium = 3,
        Large = 5
    }

    public enum AnimalFood
    {
        Carnivore,
        Herbivore
    }

    public class Animal
    {
        // Propterties
        public string AnimalName { get; private set; }
        public AnimalSize AnimalSize { get; private set; }
        public AnimalFood AnimalFood { get; private set; }

        public Animal(string animalName, AnimalSize animalSize, AnimalFood animalFood)
        {
            this.AnimalName = animalName;
            AnimalSize = animalSize;
            AnimalFood = animalFood;
        }

        public bool CheckIfAnimalIsDangerous(Animal animal)
        {
            if (animal.AnimalFood == AnimalFood.Carnivore && animal.AnimalSize >= AnimalSize || AnimalFood == AnimalFood.Carnivore && animal.AnimalSize <= AnimalSize)
                return true;
            return false;
        }

        public override string ToString() => AnimalName + " " + AnimalSize + " " + AnimalFood;
    }
}
