package com.casino;

public class Main {
    public static void main(String[] args) {
        long numerator = 600851475143L;
        long denumerator = 2;
        do {
            if (numerator % denumerator == 0) {
                numerator = numerator / denumerator;
            } else {
                denumerator++;
            }
        } while (numerator >= denumerator * denumerator);
        System.out.println("Highest prime factor: " + numerator);
    }
}
