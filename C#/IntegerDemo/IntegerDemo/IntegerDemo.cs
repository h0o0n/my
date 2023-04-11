using System;

class IntegerDemo
{
    static void Main(string[] args)
    {
        sbyte sb = 127;
        short st = 32767;
        int min = Int32.MinValue;
        long max = Int32.MaxValue;

        Console.WriteLine("{0},{1},{2},{3}" ,sb, st, min, max);
    }
}

