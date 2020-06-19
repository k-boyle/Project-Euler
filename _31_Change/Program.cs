using System;

namespace _31_Change {
    class Program {
        static void Main(string[] args) {
            var coins = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };
            Console.WriteLine(Possibilities(200, coins));
        }

        static int Possibilities(int target, int[] coins) {
            var permutations = new int[target + 1];
            permutations[0] = 1;

            foreach (int coin in coins) {
                for (int i = coin; i <= target; i++) {
                    permutations[i] += permutations[i - coin];
                }
            }

            return permutations[target];
        }
    }
}
