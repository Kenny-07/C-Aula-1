using System;

namespace C_Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Primeira Nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            string situacao = "";

            Console.WriteLine("Média:  " + media);

            if(media > 7) {
                situacao = "Aprovado";
            } else {
                situacao = "Reprovado";
            }

            Console.WriteLine(situacao);
        }
    }
}
