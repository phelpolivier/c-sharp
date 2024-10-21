/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 17/04/2024
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace calculadora
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
		
		void Button1Click(object sender, EventArgs e)
		{
			float v1=float.Parse(textBox1.Text);
			float v2=float.Parse(textBox2.Text);
			float soma=v1+v2;
			label4.Text=soma.ToString();
		}

        void button2_Click(object sender, EventArgs e)
        {
			float v1=float.Parse(textBox1.Text);
			float v2=float.Parse(textBox2.Text);
			float subtracao = v1 - v2;
			label4.Text=subtracao.ToString();
        }

        void button3_Click(object sender, EventArgs e)
        {
			float v1=float.Parse(textBox1.Text);
			float v2=float.Parse(textBox2.Text);
			float multiplicacao = v1 * v2;
			label4.Text=multiplicacao.ToString();
        }

        void button4_Click(object sender, EventArgs e)
        {
			float v1=float.Parse(textBox1.Text);
			float v2=float.Parse(textBox2.Text);
			float divisao = v1 / v2;
			label4.Text=divisao.ToString();
        }
    }
}
