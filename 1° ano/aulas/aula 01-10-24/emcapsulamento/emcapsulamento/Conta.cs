
using System;

namespace emcapsulamento
{
	public class Conta
	{
		private int numero;// Isso é um atributo
		private string titular;
		protected double saldo;
		
		// Construtor sem parâmetros
		public Conta()
		{
		}
		
		// Construtor com parâmetros
		public Conta(int numero,string titular,double saldo) {
			this.numero = numero;
			this.titular = titular;
			this.saldo = saldo;
		}
		
		// Getters
		public int GetNumero() {
			return numero;
		}
		
		public string GetTitular() {
			return titular;
		}
		
		public double GetSaldo() {
			return saldo;
		}
		
		// Setters
		public void SetNumero(int numero) {
			this.numero = numero;
		}
		
		public void SetTitular(string titular) {
			this.titular = titular;
		}
		
		// Setter do saldo(deposito e saque)
		public void Saque(double valor) {
			this.saldo -= valor;
		}
		
		public void Deposito(double valor) {
			this.saldo += valor;
		}
	}
}
