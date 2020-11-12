using System;

namespace C_Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Primeiro Número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = numero1 + numero2;

            Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
        }
    }
}
