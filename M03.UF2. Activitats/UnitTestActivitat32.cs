using Program;

namespace TestProject1
{
    [TestClass]
    public class ValidateTest
    {
        [TestMethod]
        public void TestCheckNumAvatarCorrect()
        {
            // Arrange
            int numAvatar = 1;
            bool expected = true;

            // Act
            bool actual = Program.Program.CheckNumAvatar(numAvatar);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckNumAvatarIncorrect()
        {
            // Arrange
            int numAvatar = 5;
            bool expected = false;

            // Act
            bool actual = Program.Program.CheckNumAvatar(numAvatar);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckLenghtNameCorrect()
        {
            // Arrange
            string name = "Pepito";
            bool expected = true;

            // Act
            bool actual = Program.Program.CheckLenghtName(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckLenghtNameIncorrect()
        {
            // Arrange
            string name = "P";
            bool expected = false;

            // Act
            bool actual = Program.Program.CheckLenghtName(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckNotCharactersSpecialCorrect()
        {
            // Arrange
            string name = "Pepito";
            bool expected = false;

            // Act
            bool actual = Program.Program.CheckNotCharactersSpecial(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckNotCharactersSpecialIncorrect()
        {
            // Arrange
            string name = "Pepito!";
            bool expected = true;

            // Act
            bool actual = Program.Program.CheckNotCharactersSpecial(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckEvilLevelCorrect()
        {
            // Arrange
            int level = 2000;
            bool expected = true;

            // Act
            bool actual = Program.Program.CheckEvilLevel(level);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCheckEvilLevelIncorrect()
        {
            // Arrange
            int level = 500;
            bool expected = false;

            // Act
            bool actual = Program.Program.CheckEvilLevel(level);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestContainsTwoVowelsCorrect()
        {
            // Arrange
            string name = "Pepito";
            bool expected = true;

            // Act
            bool actual = Program.Program.ContainsTwoVowels(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestContainsTwoVowelsIncorrect()
        {
            // Arrange
            string name = "Pept";
            bool expected = false;

            // Act
            bool actual = Program.Program.ContainsTwoVowels(name);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestReparEvilLevelCorrect()
        {
            // Arrange
            int level = 1000;
            int prs1 = 0;
            int prs2 = 0;
            int prs3 = 0;
            int prs4 = 0;
            bool containsTwoVowels = true;
            int expectedPrs1 = 250;
            int expectedPrs2 = 250;
            int expectedPrs3 = 250;
            int expectedPrs4 = 250;

            // Act
            Program.Program.ReparEvilLevel(level, ref prs1, ref prs2, ref prs3, ref prs4, containsTwoVowels);

            // Assert
            Assert.AreEqual(expectedPrs1, prs1);
            Assert.AreEqual(expectedPrs2, prs2);
            Assert.AreEqual(expectedPrs3, prs3);
            Assert.AreEqual(expectedPrs4, prs4);
        }

        [TestMethod]
        public void TestReparEvilLevelCorrect2()
        {
            // Arrange
            int level = 1000;
            int prs1 = 0;
            int prs2 = 0;
            int prs3 = 0;
            int prs4 = 0;
            bool containsTwoVowels = false;
            int expectedPrs1 = 50;
            int expectedPrs2 = 50;
            int expectedPrs3 = 50;
            int expectedPrs4 = 50;

            // Act
            Program.Program.ReparEvilLevel(level, ref prs1, ref prs2, ref prs3, ref prs4, containsTwoVowels);

            // Assert
            Assert.AreEqual(expectedPrs1, prs1);
            Assert.AreEqual(expectedPrs2, prs2);
            Assert.AreEqual(expectedPrs3, prs3);
            Assert.AreEqual(expectedPrs4, prs4);
        }

        [TestMethod]
        public void TestReparEvilLevelIncorrect()
        {
            // Arrange
            int level = 1000;
            int prs1 = 0;
            int prs2 = 0;
            int prs3 = 0;
            int prs4 = 0;
            bool containsTwoVowels = true;
            int expectedPrs1 = 50;
            int expectedPrs2 = 50;
            int expectedPrs3 = 50;
            int expectedPrs4 = 50;

            // Act
            Program.Program.ReparEvilLevel(level, ref prs1, ref prs2, ref prs3, ref prs4, containsTwoVowels);

            // Assert
            Assert.AreNotEqual(expectedPrs1, prs1);
            Assert.AreNotEqual(expectedPrs2, prs2);
            Assert.AreNotEqual(expectedPrs3, prs3);
            Assert.AreNotEqual(expectedPrs4, prs4);
        }
    }
}