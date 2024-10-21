/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 24/04/2024
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aplicativos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CalculadoraToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				System.Diagnostics.Process.Start("calc.exe");
			}
			catch{
				MessageBox.Show("A Calculadora não foi encontrada");
			}
			
		}// Fim botão calculadora
		
		void BlocoDeNotasToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				System.Diagnostics.Process.Start("notepad.exe");
			}
			catch{
				MessageBox.Show("O Bloco de Notas não foi encontrado");
			}
		}// Fim botão bloco de notas
		
		void WordToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				System.Diagnostics.Process.Start("winword.exe");
			}
			catch{
				MessageBox.Show("O Word não foi encontrado");
				System.Diagnostics.Process.Start("wordpad.exe");
			}
		}// Fim botão Word
		
		void ExcelToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				System.Diagnostics.Process.Start("excel.exe");
			}
			catch{
				MessageBox.Show("O Excel não foi encontrado");
			}
		}// Fim botão Excel
		
		void CalendárioToolStripMenuItemClick(object sender, EventArgs e)
		{
			//Nome da Classe Variável = new Nome da Classe();
			//Exemplo:
			//Carro(Nome da Classe) opala(variável) = new Carro()(Nome da Classe); 
			Calendario calendario = new Calendario();
			calendario.Show();
		}
		
		void TabuadaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Tabuada tabuada=new Tabuada();
			tabuada.Show();
		}
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
