using System.Numerics;
using System;

namespace _16_Sum {
    class Program {
        static void Main(string[] args) {
            BigInteger number = BigInteger.Pow(2, 1000);
            Console.WriteLine(SumDigits(number));
        }

        static BigInteger SumDigits(BigInteger number) {
            if (number == 0) {
                return 0;
            }

            return number % 10 + SumDigits(number / 10);
        }
    }
}
