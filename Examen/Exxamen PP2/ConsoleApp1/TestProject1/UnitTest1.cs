using Program;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckLenght()
        {
            // Arrange
            string str = "Perfecta";
            bool expected = true;

            // Act
            bool actual = Program.Program.CheckLenght(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckLenghtIncorrect()
        {
            // Arrange
            string str = "Una";
            bool expected = false;

            // Act
            bool actual = Program.Program.CheckLenght(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckEspecialCharacters()
        {
            // Arrange
            string str = "Adeu";
            bool expected = false;

            // Act
            bool actual = Program.Program.CheckEspecialCharacters(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckEspecialCharactersIncorrect()
        {
            // Arrange
            string str = "Hola@";
            bool expected = true;

            // Act
            bool actual = Program.Program.CheckEspecialCharacters(str);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}