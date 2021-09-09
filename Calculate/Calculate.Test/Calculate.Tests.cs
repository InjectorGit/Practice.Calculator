using NUnit.Framework;

namespace Calculate.Test
{
    public class PLUSTests
    {

        [TestCase(4, 5, 9)]
        [TestCase(2, 8, 10)]
        [TestCase(-3, -2, -5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new PLUS();

            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class MINUSTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(55, 3, 52)]
        [TestCase(-3, -3, 0)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new MINUS();

            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class DIVITIONTests
    {
        [TestCase(3, 1, 3)]
        [TestCase(10, 2, 5)]
        [TestCase(-4, -2, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new DIVITION();

            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class MULTIPLYTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-3, -3, 9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new MULTIPLY();

            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

    public class MUNIMUMTests
    {
        [TestCase(55, 8, 8)]
        [TestCase(3, 4, 3)]
        [TestCase(-3, -5, -5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            //ARRANGE
            var calc = new MINIMUM();

            //ACT
            double actualResult = calc.Calculate(firstValue, secondValue);

            //ASSERT
            Assert.AreEqual(expected, actualResult);
        }
    }

}