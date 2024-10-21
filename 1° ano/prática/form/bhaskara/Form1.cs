namespace bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);

            double delta = (Math.Pow(b, 2)) - 4 * a * c;
            label5.Text = "Delta = " + delta;

            if (delta >= 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                label6.Text = "O resultado é: "  + "\n{" + x1 + "," + x2 + "}";
                label8.Text = "x¹ = " + x1;
                label9.Text = "x² = " + x2;
            }
            else
            {
                label6.Text = "Não é possível fazer essa equação do segundo \ngrau, pois Delta não pode ser negativo.";
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
            label6.Text = "";
            label8.Text = "";
            label9.Text = "";
        }
    }
}
