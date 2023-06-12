using Exam1.Models;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodQualityQ_1()
        {
            Harmfulness hm = new Harmfulness("Дамаскин", 2000, 0.2, 2);
            Assert.AreEqual(hm.QualityQ(), (decimal)200400.0);
        }
    }
}