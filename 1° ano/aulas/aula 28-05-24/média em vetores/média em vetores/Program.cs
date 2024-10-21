/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 28/05/2024
 * Time: 20:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace média_em_vetores
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite seu nome: ");
			string nome = Console.ReadLine();
			double[] notas = new double[8];
			
			double soma = 0;
			for (int cont = 0; cont < 8; cont++) {
				Console.WriteLine("Digite a " + (cont+1) + "ª nota");
				notas[cont] = double.Parse(Console.ReadLine());
				soma += notas[cont];
			}
			double media = soma/8;
			for (int cont = 0; cont < 8; cont++) {
				Console.WriteLine("A " + (cont+1) + "ª nota é " + notas[cont]);
			}
			Console.WriteLine("");
			Console.WriteLine(nome + ", a sua média é " + media);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}