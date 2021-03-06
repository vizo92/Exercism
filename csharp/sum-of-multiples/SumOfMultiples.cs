﻿using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> toSumUp = new List<int>();

        foreach (int num in multiples)
        {
            for (int i = 0; i < max; i++)
            {
                if ((num * i) < max) toSumUp.Add(num * i);
                else if (num * i >= max) break;
            }
        }

        return toSumUp.Distinct().Sum();
    }
}