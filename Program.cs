using System;

namespace C_Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Cor do sémaforo (Vermelho, Amarelo ou Verde): ");
            string cor = (Console.ReadLine());

            if(cor == "Vermelho"){
                Console.WriteLine("Pare o Carro");
            }
             else if(cor == "Amarelo"){
                Console.WriteLine("Desacelere o Carro");
            }
             else{
                Console.WriteLine("Prossiga");
            }
        }
    }
}
