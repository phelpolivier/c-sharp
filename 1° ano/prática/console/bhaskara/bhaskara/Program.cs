namespace bhaskara
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            double delta = (Math.Pow(b, 2)) -4 * a * c;
            Console.WriteLine("Delta= " + delta);
            if (delta >= 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a ;
                Console.WriteLine("O resultado dessa equação do segundo grau é: {" + x1 + "," + x2 + "}.");
            }
            else
            {
                Console.WriteLine("Não é possível fazer essa equação do segundo grau, pois Delta não pode ser menor que zero");
            }

            Console.ReadKey();
        }
    }
}
