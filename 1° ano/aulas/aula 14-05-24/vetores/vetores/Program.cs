
using System;

namespace vetores
{
	class Program
	{
		public static void Main(string[] args)
		{
			double[] notas = new double[10];
			
			//leitura das notas 
			for (int contador = 0; contador < 10; contador++)
		{
				Console.Write("Digite a " +(contador + 1 )+"ª nota: ");
				notas[contador] =double.Parse(Console.ReadLine());
				Console.Clear();
		}
        
			for (int contador = 0; contador < 10; contador++)
			{
				Console.WriteLine("A "+ (contador + 1)+"ª nota é " + notas[contador]);
			
            }
			Console.ReadKey();
		}
	}
}