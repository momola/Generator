using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Momola.Random.Abstraction;
using Momola.Random.Generators;
using NUnit.Framework;

namespace Momola.Random.Tests.Generators
{
    [TestFixture]
    class RandomDateTests
    {
            [Test]
            public void GetRandomShouldReturnNotNullOrEmptyDate()
            {   //Arrange

                //Act 
                IRandomDate dateGen = new RandomDate();
                DateTime result = dateGen.GetRandom();

                //Assert
                Assert.IsNotNull(result.ToShortDateString(), "GetRandom should return not empty datetime");
                Assert.IsNotEmpty(result.ToShortDateString(), "Get random should return not empty or white space value");
            }
          [TestCase("1/1/1990", "30/12/1990")]
            public void GetRandomShouldReturnNotEmptyDateBetweenDates(DateTime startTime, DateTime endTime)
            {
                //Arrange

                //Act 
                IRandomDate dateGen = new RandomDate();
                DateTime result = dateGen.GetRandom(startTime, endTime);

                //Assert
                Assert.IsNotNull(result, "Get random should return not null value.");
                Assert.IsNotEmpty(result.ToShortDateString(), "Get random should return not empty or white space value");
            }
         [TestCase(2000)]
            public void GetRandomShouldReturnNotEmptyDateWithYear(int year)
            {
                //Arrange

                //Act 
                IRandomDate dateGen = new RandomDate();
                DateTime result = dateGen.GetRandom(year);

                //Assert
                Assert.IsNotNull(result, "Get random should return not null value.");
                Assert.IsNotEmpty(result.ToShortDateString(), "Get random should return not empty or white space value");
            }
         [TestCase(1900, 12)]
            public void GetRandomShouldReturnNotEmptyDateWithYearAndMonth(int year, int month)
            {
                //Arrange

                //Act 
                IRandomDate dateGen = new RandomDate();
                DateTime result = dateGen.GetRandom(year, month);

                //Assert
                Assert.IsNotNull(result, "Get random should return not null value.");
                Assert.IsNotEmpty(result.ToShortDateString(), "Get random should return not empty or white space value");
            }






    }
}
