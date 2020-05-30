package com.casino;

public class Main {
    public static void main(String[] args) {
        long numerator = 600851475143L;
        long denominator  = 2;
        do {
            if (numerator % denominator  == 0) {
                numerator = numerator / denominator ;
            } else {
                denominator ++;
            }
        } while (numerator >= denominator  * denominator );
        System.out.println("Highest prime factor: " + numerator);
    }
}
