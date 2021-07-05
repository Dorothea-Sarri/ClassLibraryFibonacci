using System;
using Xunit;

namespace ClassLibraryFibonacci.Test {
    public class FakeFibonacciTest : IFibonacciCalculator {
        public long FFibonacciSeries(long n) {
            return 91;
        }
    }

    public class FibonacciTest {
       
        private ClassFibonacci CreateDefaultSUT() {
            var sut = new ClassFibonacci(new FibonacciSeries());
            return sut;
        }
        //[Theory]
        //[InlineData(0,0)]
        //[InlineData(1, 1)]
        //[InlineData(1, 5)]
        //[InlineData(1, 9)]
        //public void Fibonacci_Calculation_ReturnsSequenceValueCorrectly(int number, int result) {
        //    var sut = CreateDefaultSUT();
          
        //    int actual = sut.FFibonacciSeries(number);
        //    Assert.Equal(result, actual);



        //}
        //[Fact]
        //public void Fibonacci_Calculation_ReturnsSequenceNegativeValue() {
        //    var sut = CreateDefaultSUT();
        //    int value = -10;

        //    Assert.Throws<ArgumentException>(() => {
        //        int actual = sut.FFibonacciSeries(value);
        //    });
        //}
        //    [Fact]
        //    public void Fibonacci_Calculation_ReturnsSequenceInvalidValue() {
        //        var sut = CreateDefaultSUT();
        //        int value = 91;

        //        Assert.Throws<ArgumentException>(() => {
        //            int actual = sut.FFibonacciSeries(value);
        //        });


        //    }

            }


    }
}
