using System;
using System.Collections.Generic;
namespace CircusTrein
{
    public class Wagon
    { 
        private List<Animal> _animals;
        private int WagonSize { get; } = 10;
        private int WagonUsedSize { get; set; } = 0;

        public Wagon()
        {
            _animals = new List<Animal>();
        }

        public bool IsAnimalAddable(Animal animal)
        {
            if (IsCorrectAnimalSizeForWagon(animal) && IsCompatibleAnimalWagon(animal))
            {
                _animals.Add(animal);
                WagonUsedSize += (int)animal.AnimalSize;
                return true;
            }
            else
                return false;
        }

        public bool IsCorrectAnimalSizeForWagon(Animal animal)
        {
            if (WagonUsedSize + (int)animal.AnimalSize <= WagonSize)
                return true;
            else
                return false;
        }

        

        public bool IsCompatibleAnimalWagon(Animal animal)
        {
            bool IsCompatible = true;

            foreach (Animal animalWagon in _animals)
            {
                if (animal.IsAnimalThreat(animalWagon))
                {
                    IsCompatible = false;
                    break;
                }
            }
            return IsCompatible;
        }

        public IReadOnlyList<Animal> GetAnimals()
        {
            return _animals;
        }
    }
}
