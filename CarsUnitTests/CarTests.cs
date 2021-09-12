using Cars.Engines;
using Cars;
using System;
using Xunit;

namespace CarsUnitTests
{
    public class CarTests
    {

        [Fact]
        public void StartPetrolEngine()
        {
            //Arrange
            var petrolEngine = new PetrolEngine();
            var expectedEngineSound = "vroom";
            var actualEngineSound = string.Empty;

            //Act
            actualEngineSound = petrolEngine.Start();

            //Assert
            Assert.Same(expectedEngineSound, actualEngineSound);
        }

        [Fact]
        public void StartPetrolCar()
        {
            //Arrange
            var petrolCar = new Car<PetrolEngine>();
            var expectedCarSound = "vroom";
            var actualCarSound = string.Empty;

            //Act
            actualCarSound = petrolCar.Start();

            //Assert
            Assert.Same(expectedCarSound, actualCarSound);
        }

        [Fact]
        public void EenPlusEenIsTwee() 
        {
            //Arrange
            var one = 1;
            var anotherOne = 1;
            var actualResult = 0;
            var expectedResult = 3;

            //Act
            actualResult = one + anotherOne;

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
