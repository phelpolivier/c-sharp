
using System;
using MySql.Data.MySqlClient;

namespace Projeto
{

	public class Conexao
	{
		public Conexao()
		{
		} // Método construtor
		
		public static MySqlConnection Conectar() {
			MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;user=root;password='root';daabase=dsn");
			conexao.Open();
			return conexao;
		} // Fim conectar	
		
	}
}
