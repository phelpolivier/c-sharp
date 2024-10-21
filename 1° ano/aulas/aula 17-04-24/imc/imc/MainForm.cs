/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 18/04/2024
 * Time: 17:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace imc
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
		
        void button1_Click(object sender, EventArgs e)
        {
			string nome = textBox1.Text;
			float peso = float.Parse(textBox2.Text.Replace('.',','));
			float altura = float.Parse(textBox3.Text.Replace(".",","));
			float imc = peso / (altura * altura);

            if (imc > 30)
            {
				label5.Text = nome + ", você está obeso, o seu IMC é " + imc;
				label5.BackColor = Color.Red;
				label5.ForeColor = Color.White;
				pictureBox1.Load("triste.jpg");
            }
			else if (imc > 25)
            {
				label5.Text = nome + ", você está com sobrepeso, o seu IMC é " + imc;
				label5.BackColor = Color.Orange;
				label5.ForeColor = Color.White;
				pictureBox1.Load("triste.jpg");
            }
			else if (imc > 18)
            {
				label5.Text = nome + ", você está com peso normal, o seu IMC é " + imc;
				label5.BackColor = Color.Green;
				label5.ForeColor = Color.White;
				pictureBox1.Load("feliz.jpg");
            }
			else
			{
				label5.Text = nome + ", você está muito magro, o seu IMC é " + imc;
				label5.BackColor = Color.Red;
				label5.ForeColor = Color.White;
				pictureBox1.Load("magro.gif");
			}
        }
    }
}
