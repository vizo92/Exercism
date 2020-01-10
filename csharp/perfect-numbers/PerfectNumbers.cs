using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if(number <= 0) throw new ArgumentOutOfRangeException();
        int sum = Enumerable.Range(1, number/2).Select(x => x).Where(y => number % y == 0).ToList().Sum();
        return sum == number ? Classification.Perfect : sum > number ? Classification.Abundant : Classification.Deficient;
    }
}
