using ClassCalciX;

namespace Classtest1
{
    public class UnitTest1
    {
        [Fact]
        public void Div_WhenCalled_ReturnsdivOfTwoNumbers()
        {
            ClaciX calci = new ClaciX();
            var result = calci.Div(4, 2);
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(2, 1, 1)]
        [InlineData(1, 1, 1)]
        public void Min_WhenCalled_Returnsresultbeasedonvale(int a, int b, int expected)
        {
            ClaciX calci = new ClaciX();
            var result = calci.Min(a, b);
            Assert.Equal(expected, result);
        }
    }
}