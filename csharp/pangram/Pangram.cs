using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g' ,'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        char[] charList = input.ToLower().ToCharArray();

        foreach (char letter in alphabet)
        {
            if(!charList.Contains(letter)) return false;
        }
        return true;
    }
}
