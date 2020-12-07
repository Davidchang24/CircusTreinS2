using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System.Collections.Generic;
using System; 

namespace UnitTests
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void Is_AnimalThread_SmallCarnivoreBigCarnivore_IsTrue()
        {
            // Arrange
            Animal animal = new Animal("Slang", AnimalSize.Small, AnimalFood.Carnivore);
            Animal animalWagon = new Animal("Leeuw", AnimalSize.Large, AnimalFood.Carnivore);

            // Act 
            bool animalIsDangerous = animal.CheckIfAnimalIsDangerous(animalWagon);

            // Assert
            Assert.IsTrue(animalIsDangerous);
        }
        [TestMethod]
        public void Is_AnimalThread_SmallCarnivoreSmallCarnivore_IsTrue()
        {
            // Arrange
            Animal animal = new Animal("Slang", AnimalSize.Small, AnimalFood.Carnivore);
            Animal animalWagon = new Animal("AndereSlang", AnimalSize.Small, AnimalFood.Carnivore);

            // Act
            bool animalIsDangerous = animal.CheckIfAnimalIsDangerous(animalWagon);

            // Assert
            Assert.IsTrue(animalIsDangerous);
        }
        [TestMethod]
        public void Is_AnimalThread_SmallCarnivoreSmallHerbivore_IsTrue()
        {
            // Arrange
            Animal animal = new Animal("Slang", AnimalSize.Small, AnimalFood.Carnivore);
            Animal animalWagon = new Animal("Bever", AnimalSize.Small, AnimalFood.Herbivore);

            // Act
            bool animalIsDangerous = animal.CheckIfAnimalIsDangerous(animalWagon);

            // Assert
            Assert.IsTrue(animalIsDangerous);
        }

        [TestMethod]
        public void Is_AnimalThread_SmallHerbivoreSmallHerbivore_IsFalse()
        {
            // Arrange
            Animal animal = new Animal("Aap", AnimalSize.Small, AnimalFood.Herbivore);
            Animal animalWagon = new Animal("Bever", AnimalSize.Small, AnimalFood.Herbivore);

            // Act
            bool animalIsDangerous = animal.CheckIfAnimalIsDangerous(animalWagon);

            // Assert
            Assert.IsFalse(animalIsDangerous);
        }

        [TestMethod]
        public void Is_AnimalThread_SmallHerbivoreLargeHerbivore_IsFalse()
        {
            // Arrange
            Animal animal = new Animal("Aap", AnimalSize.Small, AnimalFood.Herbivore);
            Animal animalWagon = new Animal("Giraffe", AnimalSize.Large, AnimalFood.Herbivore);

            // Act
            bool animalIsDangerous = animal.CheckIfAnimalIsDangerous(animalWagon);

            // Assert
            Assert.IsFalse(animalIsDangerous);
        }

        [TestMethod]
        public void Is_AnimalThread_MediumHerbivoreLargeCarnivore_IsTrue()
        {
            // Arrange
            Animal animal = new Animal("Aap", AnimalSize.Small, AnimalFood.Herbivore);
            Animal animalWagon = new Animal("Panter", AnimalSize.Large, AnimalFood.Carnivore);

            // Act
            bool animalIsDangerous = animal.CheckIfAnimalIsDangerous(animalWagon);

            // Assert
            Assert.IsTrue(animalIsDangerous);
        }

        [TestMethod]
        public void Is_AnimalThread_MediumHerbivoreSmallCarnivore_IsFalse()
        {
            // Arrange
            Animal animal = new Animal("Gorilla", AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animalWagon = new Animal("Slang", AnimalSize.Small, AnimalFood.Carnivore);

            // Act
            bool animalIsDangerous = animal.CheckIfAnimalIsDangerous(animalWagon);

            // Assert
            Assert.IsFalse(animalIsDangerous);
        }
    }
}
