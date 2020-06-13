public class Main {
    public static void main(String[] args) {
        //https://en.wikipedia.org/wiki/Sieve_of_Sundaram
        final int n = (Integer.MAX_VALUE - 1) / 2;
        final int primeIndex = 10001;
        int k = (n - 2) / 2;

        boolean[] flags = new boolean[k + 1];

        for(int i = 1; i <= k; i++) {
            int index;
            for (int j = 1; (index = i + j + 2 * i * j) <= k; j++) {
                flags[index] = true;
            }
        }

        int primeCounter = 1;
        for (int i = 1; i <= k; i++) {
            if (!flags[i]) {
                if (++primeCounter == primeIndex) {
                    System.out.println(2 * i + 1);
                }
            }
        }
    }
}
