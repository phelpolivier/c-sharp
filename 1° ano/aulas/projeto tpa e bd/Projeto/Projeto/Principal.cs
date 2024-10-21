/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 27/08/2024
 * Time: 21:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto
{
	/// <summary>
	/// Description of Principal.
	/// </summary>
	public partial class Principal : Form
	{
		public Principal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ProdutosToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm produto = new MainForm();
					//this.hide();
					produto.ShowDialog();
		} // Fim void produtos
		
		void ClientesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cliente cliente = new Cliente();
			cliente.ShowDialog();
		} // Fim void Clientes
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			Login.Sair();
		} // Fim void Sair
		
		void LoginToolStripMenuItemClick(object sender, EventArgs e)
		{
			Login login = new Login();
			this.Dispose();
			login.ShowDialog();	
			
		} // Fim void Login
		
	} // Fim public partial class Principal: Form
	
} // Fim namespace
