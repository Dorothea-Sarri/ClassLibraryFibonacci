using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFibonacci
{
    public class ClassFibonacci : IFibonacciCalculator {

        private readonly IFibonacciCalculator fibonacciCalculator;
        public ClassFibonacci(IFibonacciCalculator fibonacciCalculator) {
            this.fibonacciCalculator = fibonacciCalculator;
              


        }

    
        public long FFibonacciSeries(long n) {
        
            if (n < 0) throw new ArgumentException("Invalid input", nameof(n));
            if (n > 91 ) throw new ArgumentException("Fibonacci result number too big", nameof(n));
            long a = 0;
            long b = 1;

            for (int i = 0; i < n; i++) {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

       
    }
}
