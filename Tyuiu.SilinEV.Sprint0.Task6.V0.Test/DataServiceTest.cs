using Tyuiu.SilinEV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SilinEV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionalArray(num);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubstractionArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(num);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultArrayValid()
        {
            var num = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(num);
            Assert.AreEqual(120, res);
        }
    }
}