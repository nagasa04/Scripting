using System;

  class Program
  {
    static void Main(string[] args)
    {
      int[,] matriz = new int[3, 3];  

      Console.WriteLine("Ingrese 9 numeros");

      for(int i = 0; i < 3; i++)
      {
        for(int j = 0; j < 3; j++)
          matriz[i, j] = int.Parse(Console.ReadLine());
      }

      for(int i = 0; i < 3; i++)
      {
        for(int j = 0; j < 3; j++)
        {
          Console.Write("[" + matriz[i, j] + "] ");
          if(j >= 2)
            Console.WriteLine();
        }
      }

      Console.WriteLine("      |");
      Console.WriteLine("      v");

      for(int i = 0; i < 3; i++)
      {
        for(int j = 0; j < 3; j++)
        {
          if(matriz[i, j] < 0)
            matriz[i, j] *= -1;

          Console.Write("[" + matriz[i, j] + "] ");

          if(j >= 2)
            Console.WriteLine();
        }
      }
    }
  }