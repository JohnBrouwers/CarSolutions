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
    }
}
