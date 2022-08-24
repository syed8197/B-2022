using ConsoleAppNew;

namespace TestProject1
{
    [TestClass]
    public class TestCalculate
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator C = new Calculator();
            int result = C.Add(10, 20);
            Assert.AreEqual(30, result);
            ;
        }
    }
}