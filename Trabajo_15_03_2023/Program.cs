// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Sucesión de Fibonacci");

Console.WriteLine("Ingresar un número Entero");

try 
{
    int n = Convert.ToInt32(Console.ReadLine());

    if (n == 1)
    {
        Console.WriteLine("1");
    }else if (n > 1)
    {
        int suma1 = 0, suma2 = 1, suma = 0;
        while (suma < n)
        {
            suma = suma1 + suma2;

            if (suma < n)
            {
                Console.Write(suma + ",");
            

                suma1 = suma2;
                suma2 = suma;
            }

        }
    }
}
catch(Exception)
{
    Console.WriteLine("Ingresar un número valido");
}