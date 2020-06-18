#include <iostream>
#include <map>

int getRepeatingCyclesLength(const int* number);

int main()
{
    int maxCycles = - 1;
    int maxValue;
    for (int i = 7; i < 1000; i++)
    {
        int cycles = getRepeatingCyclesLength(&i);
        if (cycles > maxCycles)
        {
            maxCycles = cycles;
            maxValue = i;
        }
    }

    std::cout << maxValue << std::endl;
}


int getRepeatingCyclesLength(const int* number)
{
    std::map<int, int> cycles;
    int dec = 1;
    for (int i = 0; ; i++)
    {
        std::map<int, int>::iterator iter = cycles.find(dec);
        if (iter != cycles.end())
        {
            return i - iter->second;
        }
        else
        {
            cycles[dec] = i;
            dec = dec * 10 % *number;
        }
        
    }
}