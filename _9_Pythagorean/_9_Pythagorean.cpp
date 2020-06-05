#include <iostream>

int sqr(const int* x);

int main()
{
    const int length = 1000;

    for (int a = 1; a < length; a++)
    {
        for (int b = 1; b < length; b++)
        {
            int c = length - a - b;
            if (sqr(&a) + sqr(&b) == sqr(&c)) {
                std::cout << a * b * c << std::endl;
                return 0;
            }
        }
    }
}

int sqr(const int* x)
{
    return std::pow(*x, 2);
}
