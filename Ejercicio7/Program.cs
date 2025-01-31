using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena de números enteros positivos separados por espacios:");
        string cadena = Console.ReadLine();

        if (EsNumero(cadena))
        {
            int[] arrNum = cadena.Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("Array de números enteros positivos:");

            foreach (int num in arrNum)
                Console.WriteLine(num);
        }
        else
            Console.WriteLine("La cadena contiene caracteres no válidos. Solo se permiten números enteros positivos separados por espacios.");
    }

    static bool EsNumero(string cadena)
    {
        foreach (char c in cadena)
        {
            if (!char.IsDigit(c) && c != ' ')
                return false;
        }
        return true;
    }
}