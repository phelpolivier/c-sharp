namespace ex003
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            float nota4 = float.Parse(Console.ReadLine());
            // -------------------------------------------------------------------------------
            float media = (nota1+nota2+nota3+nota4) / 4;
            if (media >= 7)
            {
                Console.WriteLine(nome + " você ficou com média " + media + ", ==Aprovado==");
            }
            else if (media >= 4) 
            {
                Console.WriteLine(nome + " você ficou com média " + media + ", ==Recuperação==");
            }
            else
            {
                Console.WriteLine(nome + " você ficou com média " + media + ", ==Reprovado==");
            }
            // ----------------------------------------------------------------------------------
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
