/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 20/08/2024
 * Time: 20:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
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
		} // Fim método construtor
		
		public void Limpar() {
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox2.Focus();
		} // Fim public void Limpar
		
		public void Cadastrar() {
			if (textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="" && textBox5.Text!="") 
			{
				try {
						string sql = "insert into produto(produto,descricao,tipo,valor) values(@produto,@descricao,@tipo,@valor)";
						MySqlCommand comando = new MySqlCommand(sql,Conexao.Conectar());
						comando.Parameters.AddWithValue("@produto",textBox2.Text);
						comando.Parameters.AddWithValue("@deascricao",textBox3.Text);
						comando.Parameters.AddWithValue("@tipo",textBox4.Text);
						comando.Parameters.AddWithValue("@valor",textBox5.Text);
						comando.ExecuteNonQuery();
						Limpar();
						MessageBox.Show("Cadastro realizado com sucesso!!");
						button1.Enabled=false;
					dataGridView1.DataSource = ExibirDados();
					}// Fim try
				catch {
						MessageBox.Show("Erro ao cadastrar");
					} // Fim catch
			} else {
					MessageBox.Show("Preencha todos os campos!");
				} // Fim else

		}// Fim public void cadastrar

		public void Excluir() {
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                try
				{
					string sql = "delete from produto where id=@id";
					MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
					comando.Parameters.AddWithValue("@id", textBox1.Text);

					comando.ExecuteNonQuery();
					MessageBox.Show("Exclusão realizada com sucesso");
				} catch {
					MessageBox.Show("Erro ao excluir");
				} // Fim catch
            } // Fim if	
			Limpar();
        } // Fim public void excluir

		public void Alterar() {
			try {
				string sql = "update produto set produto=@produto,descricao=@descricao,tipo=@tipo,valor=@valor, where id=@id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
				comando.Parameters.AddWithValue("@id",textBox1.Text);
				comando.Parameters.AddWithValue("@produto",textBox2.Text);
				comando.Parameters.AddWithValue("@descricao",textBox3.Text);
				comando.Parameters.AddWithValue("@tipo",textBox4.Text);
				comando.Parameters.AddWithValue("@valor",textBox5.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("Alteração realizada com sucesso");
				Limpar();
            } catch {
				MessageBox.Show("Erro ao alterar");
			} // Fim catch
		} // Fim public void alterar
		
		public DataTable ExibirDados() {
			try {
				string sql = "SELECT * FROM produto";
				DataTable dt = new DataTable();
				dt = new DataTable();
				MySqlDataAdapter da = new MySqlDataAdapter(sql, Conexao.Conectar());
				da.Fill(dt);
				return dt;
			} catch {
				throw;
			} // Fim catch
		} // fim public exibirdados

		public DataTable BuscarProduto() {
			try {
				string sql = "SELECT * FROM produto where produto like '%' @produto '%'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
				comando.Parameters.AddWithValue("@produto",textBox6.Text);
				DataTable dt = new DataTable();
				dt = new DataTable();
				MySqlDataAdapter da = new MySqlDataAdapter(comando);
				da.Fill(dt);
				return dt;
            } catch {
				throw;
			} // Fim catch
		} // Fim public buscarproduto

		public void Selecionar() {
			textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			button1.Enabled = false;
        } // Fim public void selecionar

        void MainForm_Load(object sender, EventArgs e)
        {
			button1.Enabled = false;
        }

        void button1_Click(object sender, EventArgs e)
        {
			Cadastrar();
        }

        void button3_Click(object sender, EventArgs e)
        {
			dataGridView1.DataSource = ExibirDados();
        }

        void button2_Click(object sender, EventArgs e)
        {
			Excluir();
			dataGridView1.DataSource = ExibirDados();
        }

        void button4_Click(object sender, EventArgs e)
        {
			Alterar();
            dataGridView1.DataSource = ExibirDados();
        }

        void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			Selecionar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BuscarProduto();
			textBox6.Clear();
			textBox6.Focus();
        }

        void button6_Click(object sender, EventArgs e)
        {
			Limpar();
			button1.Enabled = true;
        }
    } // Fim public partial class MainForm : Form
} // Fim namespace
