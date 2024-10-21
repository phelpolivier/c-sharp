/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 20/08/2024
 * Time: 22:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		} // Fim Método Construtor
		
		public void Acesso() {
			try {
				string sql = "SELECT usuario,senha from login WHERE usuario=@usuario AND senha =@senha";
				MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
				comando.Parameters.AddWithValue("@usuario",textBox1.Text);
				comando.Parameters.AddWithValue("@senha",textBox2.Text);
				
				MySqlDataReader dados = comando.ExecuteReader();
				
				while (dados.Read()) { // Enquanto existir registros leia
					if (dados.HasRows) { // Se achar o usuário e senha
						Principal pricipal = new Principal();
						this.Hide();
						pricipal.ShowDialog();
					}	// Fim if
				} // Fim while
				
				MessageBox.Show("Usuário e/ou senha inválidos");
					textBox1.Clear();
					textBox2.Clear();
					textBox1.Focus();
			} catch(Exception e) { // Fim try 
				MessageBox.Show("Problemas na conexão" + e);
			} // Fim catch
			
		} // Fim public void Acesso
		
		public static void Sair() {
			if (MessageBox.Show("Tem certeza que deseja realmente sair?" , "Confirmação",
			                    MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
				Application.Exit();
			} // Fim if
		} // Fim public static void Sair
		
		void Button2Click(object sender, EventArgs e)
		{
			Sair();
		}// Fim Botão de Sair
		
		void Button1Click(object sender, EventArgs e)
		{
			Acesso();
		}
	} // Fim public partial class Login: Form
	
} // Fim namespace Projeto
