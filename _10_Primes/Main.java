import java.util.stream.LongStream;

public class Main {
    public static void main(String[] args) {
        //https://en.wikipedia.org/wiki/Sieve_of_Sundaram
        final int n = 2000000;
        int k = (n - 2) / 2;

        boolean[] primes = new boolean[k + 1];

        for(int i = 1; i <= k; i++) {
            int index;
            for (int j = 1; (index = i + j + 2 * i * j) <= k; j++) {
                primes[index] = true;
            }
        }

        long total = 2 + LongStream.range(0, primes.length)
            .reduce((rollingTotal, index) -> rollingTotal + (primes[(int) index] ? 0 : 2 * index + 1))
            .orElseThrow();
        System.out.println(total);
    }
}
