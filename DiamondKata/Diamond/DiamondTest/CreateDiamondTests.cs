using Diamond;
using NUnit.Framework;

namespace DiamondTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create_A_Should_Return_A()
        {
            DiamondService d = new DiamondService('A');
            var diamonds = d.Create();

            Assert.IsTrue(diamonds.Length == 1);
            Assert.AreEqual(diamonds[0], "A");
        }

        [Test]
        public void Create_B_Should_Return_Correct_Strings()
        {
            DiamondService d = new DiamondService('B');
            var diamonds = d.Create();

            Assert.IsTrue(diamonds.Length == 2);
            Assert.AreEqual(diamonds[0], "_A_");
            Assert.AreEqual(diamonds[1], "B_B");
        }

        [Test]
        public void Create_C_Should_Return_Correct_Strings()
        {
            DiamondService d = new DiamondService('C');
            var diamonds = d.Create();

            Assert.IsTrue(diamonds.Length == 3);
            Assert.AreEqual(diamonds[0], "__A__");
            Assert.AreEqual(diamonds[1], "_B_B_");
            Assert.AreEqual(diamonds[2], "C___C");
        }

        [Test]
        public void Create_D_Should_Return_Correct_Strings()
        {
            DiamondService d = new DiamondService('D');
            var diamonds = d.Create();

            Assert.IsTrue(diamonds.Length == 4);
            Assert.AreEqual(diamonds[0], "___A___");
            Assert.AreEqual(diamonds[1], "__B_B__");
            Assert.AreEqual(diamonds[2], "_C___C_");
            Assert.AreEqual(diamonds[3], "D_____D");
        }

        [Test]
        public void Create_For_Wrong_Character_Should_Return_Null()
        {
            DiamondService d = new DiamondService('1');
            var diamonds = d.Create();

            Assert.IsNull(diamonds);
        }

        [Test]
        public void Create_For_Small_Letter_Should_Return_Null()
        {
            DiamondService d = new DiamondService('c');
            var diamonds = d.Create();

            Assert.IsNull(diamonds);
        }
    }
}