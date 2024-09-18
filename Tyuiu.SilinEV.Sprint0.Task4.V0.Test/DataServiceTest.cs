using Tyuiu.SilinEV.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SilinEV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(DataService.Additional(5, 5), 10);
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(DataService.Subtraction(10, 5), 5);
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(DataService.Multiplication(5, 10), 50);
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(DataService.Division(9, 3), 3);
        }
        
    }
}