using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System.Collections.Generic;
using System;

namespace UnitTests
{
    [TestClass()]
    public class TrainTests
    {
        [TestMethod()]
        public void PutAnimalsInWagon_2SmallHerb1MediumHerb1BigHerb_IsTrue()
        {
            // Arrange
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("", AnimalSize.Small, AnimalFood.Herbivore));
            animals.Add(new Animal("", AnimalSize.Small, AnimalFood.Herbivore));
            animals.Add(new Animal("", AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal("", AnimalSize.Large, AnimalFood.Herbivore));

            // Act
            Train train = new Train();
            train.PutAnimalsInWagon(animals);
            IReadOnlyList<Animal> AnimalsInWagon = train.GetAnimals();

            // Assert
            Assert.IsTrue(AnimalsInWagon[0].AnimalSize == AnimalSize.Small & AnimalsInWagon[0].AnimalFood == AnimalFood.Herbivore);
            Assert.IsTrue(AnimalsInWagon[1].AnimalSize == AnimalSize.Medium & AnimalsInWagon[1].AnimalFood == AnimalFood.Herbivore);
            Assert.IsTrue(AnimalsInWagon[2].AnimalSize == AnimalSize.Large & AnimalsInWagon[2].AnimalFood == AnimalFood.Herbivore);
        }
    }
}
