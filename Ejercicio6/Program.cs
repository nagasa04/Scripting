using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de n: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0;
        int contador = 0;
        int numeroImpar = 1;

        do
        {
            suma += numeroImpar;
            numeroImpar += 2;
            contador++;
        } while(contador < n);

        Console.WriteLine("La suma de los primeros " + n + " números impares es: " + suma);
    }
}
