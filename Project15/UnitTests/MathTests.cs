using MathDemo;

namespace UnitTests
{
    [TestClass]
    public class MathTests
    {
        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 1, 1)]
        [DataRow(100, 10, 100)]
        public void CanDetectIfRootIsInteger(int maxIntToCheck, int count, int lastInt)
        {


            var ints = MathDemo.Square_roots.FindIntegerRoots(maxIntToCheck);

            Assert.IsNotNull(ints, "ints was null");
            Assert.AreEqual(count, ints.Count, "wrong amount of ints");
            Assert.AreEqual(lastInt, ints.Last(), "result was wrong");

        }
    }
}