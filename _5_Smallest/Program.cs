using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_Smallest {
    class Program {
        static void Main(string[] args) {
            var divisors = Enumerable.Range(2, 19);
            Console.WriteLine(Enumerable.Range(20, int.MaxValue - 20).First(i => IsDivisable(i, divisors)));
        }
        
        private static bool IsDivisable(int numerator, IEnumerable<int> divisors) {
            return divisors.All(x => numerator % x == 0);
        }
    }
}