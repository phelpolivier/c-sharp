using System;
using System.Drawing;
using System.Windows.Forms;

namespace aplicativos
{
	/// <summary>
	/// Description of Tabuada.
	/// </summary>
	public partial class Tabuada : Form
	{
		public Tabuada()
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
			int tabuada=int.Parse(textBox1.Text);
			
			for(int cont=0;cont<=10;cont++)
			{
				listBox1.Items.Add(tabuada+"x"+cont+"="+tabuada*cont);
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			textBox1.Clear();
			textBox1.Focus();
		}
	}
}
