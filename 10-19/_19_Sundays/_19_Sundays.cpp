#include <iostream>

int zellers(const int* year, const int* month, const int* day);

int main()
{
    const int numberOfYears = 100;
    const int monthsInYear = 12;
    const int startYear = 1901;
    const int endYear = 2000;
    const int sunday = 1;
    int sundays;

    for (int year = startYear; year <= endYear; year++)
    {
        for (int month = 1; month <= monthsInYear; month++)
        {
            if (zellers(&year, &month, &sunday) == 0)
            {
                sundays++;
            }
        } 
    }

    std::cout << sundays << std::endl;
}

int zellers(const int* year, const int* month, const int* day)
{
    int m = (*month - 3 + 4800) % 4800;
    int k = (*year + m / 12) % 400;
    return (k + k / 4 - k / 100 + (13 * m + 2) / 5 + *day + 2) % 7;  
}