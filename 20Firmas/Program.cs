using System;
using System.Collections;
using System.Collections.Generic;

  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Escriba el numero de la firma (1-20) que quiere ejecutar");

        string input = Console.ReadLine() ?? string.Empty;

        if(uint.TryParse(input, out uint number))
        {
            switch(number)
            {
                case 1: //Sumar
                    Console.WriteLine("Sumar");

                    int resultado = Sumar(1, 2);
                    Console.WriteLine(resultado);
                    break;
                case 2: //Aumento
                    Console.WriteLine("Aumento");

                    int numero = 5;
                    Aumento(ref numero);
                    Console.WriteLine(numero);
                    break;
                case 3: //ComprobarEdad
                    Console.WriteLine("Comprobar Edad");

                    ComprobarEdad(15);
                    ComprobarEdad(22);
                    break;
                case 4: //AplicarOperacion
                    Console.WriteLine("Aplicar Operacion");

                    int[] nums = { 1, 2, 3, 4, 5 };
                    AplicarOperacion(nums, x => x * x);
                    break;
                case 5: //FiltrarPares
                    Console.WriteLine("Filtra Pares");

                    var pares = FiltrarPares(new List<int> { 1, 2, 3, 4, 5 });
                    foreach (var numerop in pares)
                        Console.WriteLine(numerop);
                    break;
                case 6: //Escribir
                    Console.WriteLine("Escribir");

                    Escribir();
                    break;
                case 7: //CrearMensaje
                    Console.WriteLine("Crear Mensaje");

                    string mensaje = CrearMensaje(saludo: "Hola", nombre: "Valentin");
                    Console.WriteLine(mensaje);
                    break;
                case 8: //ListaNumeros
                    Console.WriteLine("Lista Numeros");

                    List<int> miLista = ListaNumeros();
                    miLista.ForEach(Console.WriteLine);
                    break;
                case 9: //Factorial
                    Console.WriteLine("Factorial");

                    int resultadoFactorial = Factorial(5);
                    Console.WriteLine(resultadoFactorial);
                    break;
                case 10: //MostrarParametros
                    Console.WriteLine("Mostrar Parametros");

                    MostrarParametros(1, "texto", 3.14, true);
                    break;
                case 11: //CalcularArea
                    Console.WriteLine("Calcular Area");

                    double radio = 5.0;
                    double area = CalcularArea(radio);
                    Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
                    break;
                case 12: //EsPar
                    Console.WriteLine("Es Par");

                    int num = 4;
                    bool esPar = EsPar(num);
                    Console.WriteLine($"El número {num} es par: {esPar}");
                    break;
                case 13: //CalcularVelocidad
                    Console.WriteLine("Calcular Velocidad");

                    float distancia = 100.0f; 
                    float tiempo = 9.58f; 

                    float velocidad = CalcularVelocidad(distancia, tiempo);
                    Console.WriteLine($"La velocidad es: {velocidad} m/s");
                    break;
                case 14: //ObtenerRgbHex
                    Console.WriteLine("Obtener Rgb Hex");

                    byte red = 255;
                    byte green = 100;
                    byte blue = 50;

                    string rgbHex = ObtenerRgbHex(red, green, blue);

                    Console.WriteLine($"El código RGB en formato hexadecimal es: {rgbHex}");   
                    break;
                case 15: //CrearPersona
                    Console.WriteLine("Crear Persona");

                    Person person = CrearPersona("Juan Pérez", 30);

                    Console.WriteLine($"Nombre: {person.Name}");
                    Console.WriteLine($"Edad: {person.Age}");
                    break;
                case 16: //ObtenerDepartamentosDeEmpleados
                    Console.WriteLine("Obtener Departamentos de Empleados");

                    Dictionary<int, string> departamentoDeEmpleados = ObtenerDepartamentosDeEmpleados();

                    Console.WriteLine("Empleados y sus departamentos:");

                    foreach (var pair in departamentoDeEmpleados)
                        Console.WriteLine($"ID Empleado: {pair.Key}, Departamento: {pair.Value}");
                    break;
                case 17: //LogError
                    Console.WriteLine("LogError");

                    try
                    {
                        throw new InvalidOperationException("Se ha producido un error inesperado.");
                    }
                    catch (Exception ex)
                    {
                        LogError(ex);
                    }
                    break;
                case 18: //ImprimirStack
                    Console.WriteLine("Imprimir Stack");

                    Stack<int> stack = new Stack<int>();

                    stack.Push(1);
                    stack.Push(2);
                    stack.Push(3);
                    stack.Push(4);
                    stack.Push(5);

                    Console.WriteLine("Contenido original de la pila:");
                    ImprimirStack(stack);
                    break;
                case 19: //AgregarYProcesarCola
                    Console.WriteLine("Agregar y Procesar Cola");

                    Queue<int> queue = new Queue<int>();

                    AgregarYProcesarCola(queue);

                    Console.WriteLine("\nContenido de la cola después del procesamiento (debería estar vacío):");
                    ImprimirQueue(queue);
                    break;
                case 20: //EncontrarMaximo
                    Console.WriteLine("Encontrar Maximo");

                    int[] intArray = { 3, 7, 1, 9, 5 };
                    int maxInt = EncontrarMaximo(intArray);
                    Console.WriteLine($"El valor máximo en el arreglo de enteros es: {maxInt}");

                    string[] stringArray = { "apple", "banana", "cherry" };
                    string maxString = EncontrarMaximo(stringArray);
                    Console.WriteLine($"El valor máximo en el arreglo de cadenas es: {maxString}");
                    break;
                default:
                    Console.Error.WriteLine("Firma no valida, ingrese un valor entre 1 y 20");
                    break;
            }
        }
        else
            Console.Error.WriteLine("Valor no valido");
    }

    static int Sumar(int a, int b) //1
    {
        return a + b;
    }

    static void Aumento(ref int valor) //2
    {
        valor++;
    }

    static void ComprobarEdad(int edad) //3
    {
        if (edad < 18)
            Console.WriteLine("Menor de edad");
        else
            Console.WriteLine("Adulto");
    }

    static void AplicarOperacion(int[] numeros, Func<int, int> operacion) //4
    {
        foreach (var numero in numeros)
            Console.WriteLine(operacion(numero));
    }

    static IEnumerable<int> FiltrarPares(IEnumerable<int> numerosp) //5
    {
        return numerosp.Where(x => x % 2 == 0);
    }

    static void Escribir() //6
    {
        Console.WriteLine("Mondongo");
    }

    static string CrearMensaje(string saludo, string nombre) //7
    {
        return $"{saludo}, {nombre}!";
    }

    static List<int> ListaNumeros() //8
    {
        return new List<int> { 1, 2, 3, 4, 5 };
    }

    static int Factorial(int n) //9
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void MostrarParametros(params object[] parametros) //10
    {
        foreach (var parametro in parametros)
            Console.WriteLine(parametro);
    }

    static double CalcularArea(double radio) //11
    {
        const double Pi = 3.141592653589793;
        double area = Pi * radio * radio;
        return area;
    }

    static bool EsPar(int num) //12
    {
        return num % 2 == 0;
    }

    static float CalcularVelocidad(float distancia, float tiempo) //13
    {
        if (tiempo == 0)
            throw new ArgumentException("El tiempo no puede ser cero.");
            
        return distancia / tiempo;
    }

    static string ObtenerRgbHex(byte red, byte green, byte blue) //14
    {
        return $"#{red:X2}{green:X2}{blue:X2}";
    }

    static Person CrearPersona(string name, int age) //15
    {
        return new Person(name, age);
    }

    static Dictionary<int, string> ObtenerDepartamentosDeEmpleados() //16
    {
        return new Dictionary<int, string>
        {
            { 101, "Ventas" },
            { 102, "Marketing" },
            { 103, "Recursos Humanos" },
            { 104, "TI" }
        };
    }

    static void LogError(Exception ex) //17
    {
        Console.WriteLine("Se ha producido un error:");
        Console.WriteLine($"Mensaje: {ex.Message}");
        Console.WriteLine($"Pila de llamadas: {ex.StackTrace}");
    }

    static void ImprimirStack(Stack<int> stack) //18
    {   
        foreach (int value in stack)
            Console.WriteLine(value);
    }   

    static void AgregarYProcesarCola(Queue<int> queue) //19-1
    {
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Procesando elementos de la cola:");
        while (queue.Count > 0)
        {
            int item = queue.Dequeue(); 
            Console.WriteLine(item);    
        }
    }

    static void ImprimirQueue(Queue<int> queue) //19-2
    {
        if (queue.Count == 0)
            Console.WriteLine("La cola está vacía.");
        else
        {
            foreach (int value in queue)
                Console.WriteLine(value);
        }
    }

    static T EncontrarMaximo<T>(T[] items) where T : IComparable<T> //20
    {
        if (items == null || items.Length == 0)
            throw new ArgumentException("El arreglo no puede ser nulo o vacío.");

        T max = items[0]; // Inicializar el valor máximo con el primer elemento

        foreach (T item in items)
        {
            if (item.CompareTo(max) > 0)
                max = item; // Actualizar el valor máximo
        }

        return max;
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
