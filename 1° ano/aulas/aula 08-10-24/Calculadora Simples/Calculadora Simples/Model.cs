/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/10/2024
 * Time: 10:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Calculadora_Simples
{
	public class Model
	{
		public Model()
		{
		} // Fim construtor
		
		// Atributos
		private float valor1;
		private float valor2;
		
		// Getters
		public float GetValor1() {
			return this.valor1;
		}
		
		public float GetValor2() {
			return this.valor2;
		}
		
		// Setters
		public void SetValor1(float valor1) {
			this.valor1 = valor1;
		}
		
		public void SetValor2(float valor2) {
			this.valor2 = valor2;
		}
		
		// Métodos
		public float Somar() {
			return this.valor1 + this.valor2;
		}
		
		public float Subtrair() {
			return this.valor1 - this.valor2;
		}
		
		public float Multiplicar() {
			return this.valor1 * this.valor2;
		}
		
		public float Dividir() {
			return this.valor1 / this.valor2;
		}
	}
}
