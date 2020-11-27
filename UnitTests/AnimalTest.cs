using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
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
            bool animalIsThreatOrThreatened = animal.IsAnimalThreatOrThreatened(animalWagon);

            // Assert
            Assert.IsTrue(animalIsThreatOrThreatened);
        }

    }
}
