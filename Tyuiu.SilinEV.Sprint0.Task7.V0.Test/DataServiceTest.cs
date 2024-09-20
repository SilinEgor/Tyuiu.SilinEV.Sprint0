using Tyuiu.SilinEV.Sprint0.Task7.V0.Lib;

namespace Tyuiu.SilinEV.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] array = { 1, 1, 1, 1, 1 };
            int[] array2 = { 1, 1, 1, 1, 1 };
            int[] array3 = { 2, 2, 2, 2, 2 };
            int[] res = DataService.AdditionArrays(array, array2);
            CollectionAssert.AreEqual(res, array3);
        }
    }
}