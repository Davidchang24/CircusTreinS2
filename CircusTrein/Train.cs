using System;
using System.Collections.Generic;
namespace CircusTrein
{
    public class Train
    {
        private List<Wagon> _wagons;
        private bool succes;
        public Train()
        {
            _wagons = new List<Wagon>();
        }

        public void PutAnimalsInWagon(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                succes = false;
                foreach (Wagon wagon in _wagons)
                {
                    if (wagon.IsAnimalAddable(animal) == true)
                    {
                        succes = true;
                        break;
                    }
                }

                if (succes == false)
                {
                    Wagon wagon = new Wagon();
                    _wagons.Add(wagon);
                }
            }
        }

        public IReadOnlyList<Wagon> GetWagons()
        {
            return _wagons;
        }

        public IReadOnlyList<Animal> GetAnimals()
        {
            List<Animal> animals = new List<Animal>();

            foreach (Wagon wagon in _wagons)
            {
                foreach (Animal animal in wagon.GetAnimals())
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }
    }
}
