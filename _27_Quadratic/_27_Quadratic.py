import math

def is_prime(n):
    if n <= 0:
        return False

    root = math.sqrt(n)
    if root % 1 == 0:
        return False

    for i in range(2, int(root) + 1):
        if n % i == 0:
            return False

    return True

def calculate(n, a, b):
    return n**2 + a * n + b

def main():
    maxPrimes = 0
    product = 0
    for a in range(-999, 999):
        for b in range(-1000, 1000):
            count = 0
            while is_prime(calculate(count, a, b)):
                count = count + 1
            
            if count > maxPrimes:
                maxPrimes = count
                product = a * b

    print (product)

if __name__ == "__main__":
    main()