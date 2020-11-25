using System;
using System.Collections.Generic;
namespace CircusTrein
{
    public class Train
    {
        private List<Wagon> _wagons;
        public Train()
        {
            _wagons = new List<Wagon>();
        }

        public void PutAnimalsInTrain(List<Animal> animals)
        {
            int wagonIndex = 0;

            while (animals.Count != 0)
            {
                AddWagon(wagonIndex, animals[0]);
                Wagon wagon = _wagons[wagonIndex];
                animals.RemoveAt(0);

                for (int i = animals.Count - 1; i >= 0; i--)
                {
                    Animal animal = animals[i];
                    if (wagon.IsAnimalAddable(animal))
                    {
                        animals.Remove(animal);
                    }
                }
                wagonIndex += 1;
            }
        }
        private void AddWagon(int wagonIndex, Animal animal)
        {
            _wagons.Add(new Wagon());
            _wagons[wagonIndex].IsAnimalAddable(animal);
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
