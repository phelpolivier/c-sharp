
using System;

namespace emcapsulamento
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Dados
			Conta phelipe = new Conta(1,"Phelipe",20000);
			ContaPoupanca phelipeJunior = new ContaPoupanca(2,"Phelipe Junior",2000,0.05);
			
			// Exibir dados
			Console.WriteLine("O " + phelipe.GetTitular() + " tem R$" + phelipe.GetSaldo());
			Console.WriteLine("O " + phelipeJunior.GetTitular() + " tem R$" + phelipeJunior.GetSaldo());
			
			// Saque
			phelipe.Saque(4000);
			phelipeJunior.Saque(1000);
			
			// Exibir os dados atualizados depois do saque
			Console.WriteLine("");
			Console.WriteLine("O " + phelipe.GetTitular() + " tem R$" + phelipe.GetSaldo());
			Console.WriteLine("O " + phelipeJunior.GetTitular() + " tem R$" + phelipeJunior.GetSaldo());
			
			// Deposito
			phelipe.Deposito(44000);
			phelipeJunior.Deposito(3000);
			
			//Exibir os dados atualizados depois do deposito
			Console.WriteLine("");
			Console.WriteLine("O " + phelipe.GetTitular() + " tem R$" + phelipe.GetSaldo());
			Console.WriteLine("O " + phelipeJunior.GetTitular() + " tem R$" + phelipeJunior.GetSaldo());
			
			// Juros da conta do Phelipe Junior
			phelipeJunior.AtualizarSaldo();
			
			// Exibir dados atualizados do Phelipe Junior
			Console.WriteLine("");
			Console.WriteLine("O " + phelipeJunior.GetTitular() + " tem R$" + phelipeJunior.GetSaldo());
			
			Console.WriteLine("");
			Console.Write("Pressione qualquer tecla para sair");
			Console.ReadKey(true);
		}
	}
}