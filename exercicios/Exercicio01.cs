using System;

namespace exercicios
{
    class Start
    {
        static void Main(string[] args)
        {
            int Celcius;
            double Farhrenheit;

            Console.WriteLine("Digite um numero em grau Celcius para converter para Farhrenheit: ");
            int.TryParse(Console.ReadLine(), out Celcius);

            Farhrenheit = Celcius * 1.8 + 32;

            Console.WriteLine("A Temperatura em Farhrenheit é: " + Farhrenheit);
        }
    }
}