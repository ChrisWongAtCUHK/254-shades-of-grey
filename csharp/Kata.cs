using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
    public static string[] ShadesOfGrey(int n)
    {
        if(n <= 0) return new string[]{};   // empty array
        if (n > 254) n = 254;

        // returns n shades of grey in an array
        return Enumerable.Range(1, n)               // create the collection from 1 to n
                         .Select(i => ToGrey(i))    // convert to grey
                         .ToArray();                // to array
    }

    /// <summary>
    /// Convert i to hex string
    /// Repeat it to 3 times
    /// Add '#' before it
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public static string ToGrey(int i)
    {
        return "#" + String.Join("", Enumerable.Repeat(i.ToString("x2"), 3));
    }
}

