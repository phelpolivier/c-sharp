/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 09/10/2024
 * Time: 10:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora_Simples
{
	public partial class MainForm : Form
	{
		// Construtor
		public MainForm()
		{
			InitializeComponent();// Aviso: NÃO EXCLUA ISSO
		} // Fim Construtor
		
		Model model = new Model();// Instanciei a classe Model
		
		// Função botão de soma
		void Button1Click(object sender, EventArgs e)
		{
			model.SetValor1(float.Parse(textBox1.Text));
			model.SetValor2(float.Parse(textBox2.Text));
			label5.Text = model.Somar().ToString();
		}
		
		// Função botão de subtração
		void Button2Click(object sender, EventArgs e)
		{
			model.SetValor1(float.Parse(textBox1.Text));
			model.SetValor2(float.Parse(textBox2.Text));
			label5.Text = model.Subtrair().ToString();
		}
		
		// Função botão de multiplicação
		void Button3Click(object sender, EventArgs e)
		{
			model.SetValor1(float.Parse(textBox1.Text));
			model.SetValor2(float.Parse(textBox2.Text));
			label5.Text = model.Multiplicar().ToString();
		}
		
		// Função botão de divisão
		void Button4Click(object sender, EventArgs e)
		{
			model.SetValor1(float.Parse(textBox1.Text));
			model.SetValor2(float.Parse(textBox2.Text));
			label5.Text = model.Dividir().ToString();
		}
		
		// Função Limpar
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			label5.Text = "0";
		}
	}
}
