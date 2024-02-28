using OOPEx;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodDrive()
        {
            // Arrange
            Car car = new Car(10);
            string expected = "The car is driving";
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            // Act
            car.Drive();
            // Assert
            Assert.AreEqual(expected, sw.ToString().Trim());
        }

        [TestMethod]
        public void TestMethodRefuel()
        {
            // Arrange
            Car car = new Car(0);
            int gasoline = 10;
            bool expected = true;
            // Act
            bool result = car.Refuel(gasoline);
            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}