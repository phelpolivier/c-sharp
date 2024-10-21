/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 28/05/2024
 * Time: 21:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace produtos
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Pergunta o nome do comprador
			Console.Write("Digite seu nome: ");
			string nome = Console.ReadLine();
			// Pergunta a quntidade de produtos que o comprador irá comprar
			Console.Write("Quantos produtos vc irá comprar? ");
			int n =  int.Parse(Console.ReadLine());
			
			// Define os Vetores
			double[] precos = new double[n];
			string[] produtos = new string[n];
			double soma = 0;
			
			// Armazenando os dados nas variáveis
			for (int cont = 0; cont < n; cont++) {
				Console.WriteLine("Digite o " + (cont + 1) + "º produto");
				produtos[cont] = Console.ReadLine();  
				Console.WriteLine("Digite o preço do " + (cont + 1) + "º produto");
				precos[cont] = double.Parse(Console.ReadLine());
				soma += precos[cont];
			}
			Console.Clear();// Limpa Tela
			// Faz a média
			double media = soma/n;
			// Exibe os dados armazenados
			for (int cont = 0; cont < n; cont++) {
				Console.WriteLine("Produto " + (cont + 1) + ": " + produtos[cont] + ", Preço: R$" + precos[cont]);
			}
			// Exibe a soma do preço dos produtos
			Console.WriteLine("Total = R$" + soma);
			// Exibe a média do preço dos produtos
			Console.WriteLine(nome + ", a média é " + media);
			
			Console.ReadKey(true);
		}
	}
} 