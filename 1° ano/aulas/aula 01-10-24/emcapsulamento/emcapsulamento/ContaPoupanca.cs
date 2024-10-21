
using System;

namespace emcapsulamento
{
	public class ContaPoupanca : Conta
	{
		private double juros; // Taxa de Juros
		
		// Construtor sem parâmetro
		public ContaPoupanca() : base()
		{
		}
		
		// Construtor com parâmetro
		public ContaPoupanca(int numero,string titular,double saldo, double juros) : base(numero, titular, saldo)
		{
			this.juros = juros;
		}
		
		// Getter 
		public double GetJuros() {
			return juros;
		}
		
		// Setter
		public void SetJuros(double juros) {
			this.juros = juros;
		}
		
		// Atualizar Saldo
		public void AtualizarSaldo() {
			saldo += saldo * juros;	
		}
	}
}
