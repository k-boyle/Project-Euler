def main():
    largest_palindrome = 0
    for x in range(999, 100, -1):
        result = find_palindromes_for(x)
        if result != -1 and result > largest_palindrome:
            largest_palindrome = result
    print(f'largest palindrome: {largest_palindrome}')


def find_palindromes_for(number):
    for y in range(999, 100, -1):
        product = number * y
        print(f'{number} * {y} = {product}')
        if is_palindrome(product):
            return product

    return -1


def is_palindrome(number):
    as_str = str(number)
    length = len(as_str)
    for i in range(length):
        if as_str[i] != as_str[length - i - 1]:
            return False
    return True


if __name__ == "__main__":
    main()