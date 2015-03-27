using System;
using Momola.Random.Abstraction;
using Momola.Random.Enums;
using Momola.Random.Generators;
using NUnit.Framework;

namespace Momola.Random.Tests.Generators
{
    [TestFixture]
    public class RandomNameTests
    {
        [Test]
        public void GetRandomShouldReturnNotEmptyString()
        {
            //Arrange
            
            //Act 
            IRandomName nameGen = new RandomName();
            string result = nameGen.GetRandom();

            //Assert
            Assert.IsFalse(String.IsNullOrWhiteSpace(result), "GetRandom should return not null or white space string");
        }

        [TestCase(Gender.Male)]
        [TestCase(Gender.Female)]
        public void GetRandomShouldReturnNotEmptyStringForBothGender(Gender gender)
        {
            //Arrange

            //Act 
            IRandomName nameGen = new RandomName();
            string result = nameGen.GetRandom(gender);

            //Assert
            Assert.IsNotNull(result, "Get random should return not null value.");
            Assert.IsNotEmpty(result.Trim(), "Get random should return not empty or white space value");
        }
    }
}
