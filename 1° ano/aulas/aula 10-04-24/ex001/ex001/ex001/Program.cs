namespace Hello_World
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome=Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade=int.Parse(Console.ReadLine());

            if (idade >= 16) {
                Console.WriteLine(nome + " você tem " + idade + " anos, você pode votar.");
            }
            else
            {
                Console.WriteLine(nome + " você tem " + idade + " anos, você não pode votar.");
            }

            Console.Write("Press any key to continue . . .");
            Console.ReadKey(true);
        }
    }
}