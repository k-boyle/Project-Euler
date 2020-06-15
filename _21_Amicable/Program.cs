using System;
using System.Linq;

namespace _21_Amicable  {
    class Program {
        static void Main() {
            int sum = Enumerable.Range(2, 10000)
                .Where(IsAmicable)
                .Sum();

            Console.WriteLine(sum);
        }

        static bool IsAmicable(int a) {
            int b = D(a);
            return b != a && D(b) == a; 
        }

        static int D(int number) {
            return Enumerable.Range(1, number / 2)
                .Where(i => number % i == 0)
                .Sum();
        }        
    }
}
