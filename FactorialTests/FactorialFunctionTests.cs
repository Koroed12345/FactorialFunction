

using FactorialFunction;

namespace FactorialTests;

[TestClass]
public class FactorialFunctionTests
{
    [TestMethod]
    public void TestCalculateWithNumbersLessZero()
    {
        int numberLessZero = -5;
        int expectedResult = 0;
        int actualResult = FactorialNumber.Calculate(numberLessZero);

        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestCalculateWithZero()
    {
        int zero = 0;
        int expectedResult = 1;
        int actualResult = FactorialNumber.Calculate(zero);

        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void TestCalculateWithNumberGreaterZero()
    {
        int numberGreaterZero = 5;
        int expectedResult = 120;
        int actualResult = FactorialNumber.Calculate(numberGreaterZero);

        Assert.AreEqual(expectedResult, actualResult);
    }
}