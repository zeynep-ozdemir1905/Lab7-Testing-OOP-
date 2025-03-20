using NUnit.Framework;
using BasicMathLibrary;

namespace BasicMathTest;
/*test cases that test all four methods to ensure they work as expected.*/

[TestFixture]
public class Tests
{
    private BasicMath math;

    [SetUp]
    public void Setup()
    {
        math = new BasicMath();
    }

    [Test]
    public void Test_AddMethod()
    {
        Assert.AreEqual(10, math.Add(5, 5));
    }

    [Test]
    public void Test_SubtractMethod()
    {
        Assert.AreEqual(2, math.Subtract(5, 3));
    }

    [Test]
    public void Test_MultiplyMethod()
    {
        Assert.AreEqual(15, math.Multiply(3, 5));
    }

    [Test]
    public void Test_DivideMethod()
    {
        Assert.AreEqual(2, math.Divide(10, 5));
    }

[Test]
    public void Test1()
    {
        Assert.AreEqual(0, math.Add(0, 0)); // additional testing for test 1 
    }
}


