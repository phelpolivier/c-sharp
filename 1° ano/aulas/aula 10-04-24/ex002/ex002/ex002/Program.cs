using System;

namespace ex002
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            // ----------------------------------------------
            float soma = v1 + v2;
            float subtracao = v1 - v2;
            float multiplicacao = v1 * v2;
            float divisao = v1 / v2;
            // ----------------------------------------------
            Console.WriteLine("A soma dos valores é " + soma);
            Console.WriteLine("A subtração dos valores é " + subtracao);
            Console.WriteLine("A multiplicação dos valores é " + multiplicacao);
            Console.WriteLine("A divisão dos valores é " + divisao);

            Console.WriteLine("Clique em qualquer botão para encerrar");
            Console.ReadKey();
        }
    }
}
