using Ex1;
using NUnit.Framework;

namespace Ex1Test
{   
    
    [TestFixture]
    public class TestRandomHelper
    {
        [Test]
        [Repeat(1000000)]
        public void TestGetFactor()
        {
            var factor = RandomHelper.GetStockFactor();
            Assert.That(factor, Is.InRange(0.2m, 2.0m));
        }
    }
}