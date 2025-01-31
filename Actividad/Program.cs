using System;

  class Program
  {
    static void Main(string[] args)
    {
        int resultadoFactorial = Factorial(5);
        Console.WriteLine(resultadoFactorial);
    }

    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
  }

