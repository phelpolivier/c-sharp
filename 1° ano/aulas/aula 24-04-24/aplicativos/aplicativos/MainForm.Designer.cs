/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 24/04/2024
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace aplicativos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calendárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.arquivoToolStripMenuItem,
									this.aplicativosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// aplicativosToolStripMenuItem
			// 
			this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.calculadoraToolStripMenuItem,
									this.blocoDeNotasToolStripMenuItem,
									this.wordToolStripMenuItem,
									this.excelToolStripMenuItem,
									this.calendárioToolStripMenuItem,
									this.tabuadaToolStripMenuItem});
			this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
			this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.aplicativosToolStripMenuItem.Text = "Aplicativos";
			// 
			// calculadoraToolStripMenuItem
			// 
			this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
			this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.calculadoraToolStripMenuItem.Text = "Calculadora";
			this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.CalculadoraToolStripMenuItemClick);
			// 
			// blocoDeNotasToolStripMenuItem
			// 
			this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
			this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
			this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.BlocoDeNotasToolStripMenuItemClick);
			// 
			// wordToolStripMenuItem
			// 
			this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
			this.wordToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.wordToolStripMenuItem.Text = "Word";
			this.wordToolStripMenuItem.Click += new System.EventHandler(this.WordToolStripMenuItemClick);
			// 
			// excelToolStripMenuItem
			// 
			this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
			this.excelToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.excelToolStripMenuItem.Text = "Excel";
			this.excelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItemClick);
			// 
			// calendárioToolStripMenuItem
			// 
			this.calendárioToolStripMenuItem.Name = "calendárioToolStripMenuItem";
			this.calendárioToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.calendárioToolStripMenuItem.Text = "Calendário";
			this.calendárioToolStripMenuItem.Click += new System.EventHandler(this.CalendárioToolStripMenuItemClick);
			// 
			// tabuadaToolStripMenuItem
			// 
			this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
			this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.tabuadaToolStripMenuItem.Text = "Tabuada";
			this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.TabuadaToolStripMenuItemClick);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1198, 565);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "aplicativos";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calendárioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
