// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        const int M = 4, N = 3;
        int Sum(int m, int n)
        {
            if(m>n)
                return 0;
            else
                return m+Sum(m+1,n);
            m++;
        }
        Console.WriteLine(Sum(M,N));
    }
}
