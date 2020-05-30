using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_Smallest {
    class Program {
        private static int counter = 20;
        
        static void Main(string[] args) {
            var divisors = Enumerable.Range(2, 19);
            Console.WriteLine(InfiniteEnumerable().First(i => IsDivisable(i, divisors)));
        }
        
        private static bool IsDivisable(int numerator, IEnumerable<int> divisors) {
            return divisors.All(x => numerator % x == 0);
        }
        
        private static IEnumerable<int> InfiniteEnumerable() {
            while (true) {
                yield return counter++;   
            }
        }
    }
}