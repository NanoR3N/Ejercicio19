using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero Entero");
            int unNumero = int.Parse(Console.ReadLine());
            if (unNumero < 0) Console.WriteLine("El numero ingresado no es un ENTERO");
            else if (unNumero % 2 == 0) Console.WriteLine("El numero ingresado es Par");
            else Console.WriteLine("El numero ingresado es Impar");
            
        }
    }
}
