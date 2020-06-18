using System.Numerics;
using System;
using System.Collections.Generic;

namespace _29_Powers {
    class Program     {
        static void Main(string[] args) {
            HashSet<BigInteger> results = new HashSet<BigInteger>();
            for (int a = 2; a <= 100; a++) {
                for (int b = 2; b <= 100; b++) {
                    results.Add(BigInteger.Pow(a, b));
                }
            }

            Console.WriteLine(results.Count);
        }
    }
}
