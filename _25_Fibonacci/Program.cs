using System.Numerics;
using System;

namespace _25_Fibonacci {
    class Program {
        static void Main(string[] args) {
            Fibonacci fib = new Fibonacci();
            int i = 1;
            for (; Math.Floor(BigInteger.Log10(fib.Value)) + 1 < 1000; i++, fib.Next());
            Console.WriteLine(i);
        }

        private class Fibonacci {
            public BigInteger Value => this._b;

            private BigInteger _a;
            private BigInteger _b;

            public Fibonacci() {
                this._a = 0;
                this._b = 1;
            }

            public void Next() {
                BigInteger temp = this._a + this._b;
                this._a = this._b;
                this._b = temp;
            }
        }
    }
}
