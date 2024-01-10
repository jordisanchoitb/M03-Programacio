using JordiSancho;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = "jordi";
            int edad = 18;

            string result = Examen.MsgUser(name, edad);

            Assert.AreEqual("Hola jordi! Tens 18 anys", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string name = "adria";
            int edad = 5;

            string result = Examen.MsgUser(name, edad);

            Assert.AreEqual("Hola adria! En ser menor d’edat, necessites autorització signada.", result);
        }
    }
}