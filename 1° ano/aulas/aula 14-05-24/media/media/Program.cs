
using System;

namespace media
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Declaração do vetor de notas
			double[] notas = new double[4];

			// Leitura e soma das notas
			double soma = 0;
            for (int contador = 0; contador < 4; contador++)
            {
				Console.Write("Digite a " + (contador + 1) + "ª nota: ");
				notas[contador] = double.Parse(Console.ReadLine());
				soma += notas[contador];
				Console.Clear();// Limpa a tela
            }
			double media = soma / 4;

            // Exibição das notas
            for (int contador = 0; contador < 4; contador++)
            {
				Console.WriteLine("A " + (contador + 1) + "ª nota é: " + notas[contador]);
            }

			//Exibição da média
			Console.WriteLine("A média das notas é " + media);

			//Aguarda o pressionamento de uma tecla para encerrar o programa
			Console.ReadKey();
        }
	}
}