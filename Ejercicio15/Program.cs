using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escribe una palabra:");
        string texto = Console.ReadLine();
        if (EsPalindromo(texto))
        {
            Console.WriteLine("Es palíndromo");
        }
        else
        {
            Console.WriteLine("No es palíndromo");
        }
    }

    public static bool EsPalindromo(string texto)
    {
        if (texto.Length <= 1)
        {
            return true;
        }
        else
        {
            if (texto[0] != texto[texto.Length - 1])
            {
                return false;
            }
            else
            {
                return EsPalindromo(texto.Substring(1, texto.Length - 2));
            }
        }
    }
}