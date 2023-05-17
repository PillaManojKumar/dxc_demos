using ClassCalci;
using System;

namespace TestCalci1
{
    public class Tests
    {
        private ClassCalci.Calci calci;

        [SetUp]
        public void Setup()
        {
            calci = new ClassCalci.Calci();
        }

        [Test]
        public void Div_WhenCalled_ReturnsdivOfTwoNumbers()
        {
            var result = calci.Div(4, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [TestCase(1, 2, 1)]
        [TestCase(2, 1, 1)]
        [TestCase(1, 1, 1)]
        public void Min_WhenCalled_Returnsresultbeasedonvale(int a, int b, int expected)
        {
            var result = calci.Min(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}