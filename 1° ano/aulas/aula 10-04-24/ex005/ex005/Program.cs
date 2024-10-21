namespace ex005
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu peso: ");
            int peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Quando foi a sua última doação(meses)? ");
            int mes = int.Parse(Console.ReadLine());

            if ( (idade >= 16) && (peso >= 50) && (mes >= 6) )
            {
               Console.WriteLine("Você pode fazer a doação de sangue :D");
            }
            else
            {
                Console.WriteLine("Você ainda não pode fazer a doação de sangue :C");
                Console.WriteLine("Quando você completar todos os requisitos, você poderá doar.");
            }

            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey();
        }
    }
}
