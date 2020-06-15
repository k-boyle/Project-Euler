import java.util.Set;
import java.util.function.Function;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class Main {
    public static void main(String... args) {
        //horrifically inefficent but cba to make not
        final int limit = 28123;
        Set<Integer> abundantNumbers = getAbundantNumbers(limit);
        Set<Integer> allPossibleSums = abundantNumbers.stream()
            .map(i -> abundantNumbers.stream().map(j -> i + j))
            .flatMap(Function.identity())
            .collect(Collectors.toSet());
        Set<Integer> allNumbers = IntStream.range(0, limit)
            .boxed()
            .collect(Collectors.toSet());
        allNumbers.removeAll(allPossibleSums);
        System.out.println(allNumbers.stream().mapToInt(i -> i.intValue()).sum());
    }

    private static Set<Integer> getAbundantNumbers(int limit) {
        return IntStream.range(12, limit)
            .filter(Main::isAbudant)
            .boxed()
            .collect(Collectors.toSet());
    }

    private static boolean isAbudant(int number) {
        return sumProperDivisors(number) > number;
    }

    private static int sumProperDivisors(int number) {
        return getProperDivisors(number).sum();
    }

    private static IntStream getProperDivisors(int number) {
        return IntStream.range(1, (number / 2) + 1)
            .filter(i -> number % i == 0);
    }
}