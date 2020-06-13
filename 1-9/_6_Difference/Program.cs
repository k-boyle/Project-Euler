using System;

namespace _6_Difference {
    class Program {
        static void Main(string[] args) {
            //difference is quartic sequence https://oeis.org/A052149
            //a(n) = n*(n-1)*(n+1)*(3*n+2)/12
            Func<int, int> a = i => i * (i - 1) * (i + 1) * (3 * i + 2) / 12;
            Console.WriteLine(a(100));
        }
    }
}