using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void AddAnimal_1BigCarnivore1BigHerbivore_IsFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Large, AnimalFood.Carnivore));

            // Act
            bool isAdded = wagon.IsAnimalAddable(new Animal("", AnimalSize.Large, AnimalFood.Herbivore));

            //Assert
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_2SmallCarnivore1BigHerbivore_IsTrue()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Small, AnimalFood.Carnivore));
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Small, AnimalFood.Carnivore));

            // Act
            bool isAdded = wagon.IsAnimalAddable(new Animal("",AnimalSize.Large, AnimalFood.Herbivore));

            //Assert
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_3MediumCarnivore1SmallHerbivore_IsFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Carnivore));
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Carnivore));
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Carnivore));

            // Act
            bool isAdded = wagon.IsAnimalAddable(new Animal("", AnimalSize.Small, AnimalFood.Herbivore));

            //Assert
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_3MediumHerbivore1SmallHerbivore_IsTrue()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Herbivore));
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Herbivore));
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Herbivore));

            // Act
            bool isAdded = wagon.IsAnimalAddable(new Animal("", AnimalSize.Small, AnimalFood.Herbivore));

            //Assert
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_3MediumHerbivore1MediumHerbivore_IsFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Herbivore));
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Herbivore));
            wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Herbivore));

            // Act
            bool isAdded = wagon.IsAnimalAddable(new Animal("", AnimalSize.Medium, AnimalFood.Herbivore));

            //Assert
            Assert.IsFalse(isAdded);
        }
    }
}