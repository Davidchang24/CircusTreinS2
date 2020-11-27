using System;
using System.Collections.Generic;

namespace CircusTrein
{
    public class Wagon
    { 
        // Properties
        private List<Animal> _animals;
        private int WagonSize { get; } = 10;
        private int WagonUsedSize { get; set; } = 0;
        public int WagonCount { get; set; }

        // Constructor
        public Wagon()
        {
            _animals = new List<Animal>();
        }

        // Methods
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
                if (animal.IsAnimalThreatOrThreatened(animalWagon))
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
