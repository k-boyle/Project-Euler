using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Triangles {
    class Program {
        static void Main(string[] args) {
            const int start = 10000;
            var triangleNumer = Enumerable.Range(start, int.MaxValue - start)
                .Select(GetTriangleNumber)
                .FirstOrDefault(i => GetNumberOfDivisors(i) > 500);
            
            Console.WriteLine(triangleNumer);
        }
        
        private static int GetTriangleNumber(int i) {
            IEnumerable<int> Values() {
                for (; i > 0; i--) {
                    yield return i;
                }
            }

            return Values().Sum();
        }
        
        private static int GetNumberOfDivisors(int i) {
            var root = Math.Sqrt(i);
            var divisors = root % 1 == 0 ? 1 : 0;
            for (int j = 1; j < root; j++) {
                if (i % j == 0) {
                    divisors += 2;
                }
            }

            return divisors;
        }
    }
}