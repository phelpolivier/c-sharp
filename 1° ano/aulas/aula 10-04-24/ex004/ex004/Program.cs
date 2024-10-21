namespace ex004
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            float peso = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc <= 18)
            {
                Console.WriteLine(nome + ", você está muito magro, o seu IMC é " + imc);
            }
            else if (imc>18 && imc<=25)
            {
                Console.WriteLine(nome + ", você está com peso normal, o seu IMC é " + imc);
            }
            else if(imc>25 && imc <=30)
            {
                Console.WriteLine(nome + ", você está com sobrepeso, o seu IMC é " + imc);
            }
            else
            {
                Console.WriteLine(nome + ", você está obeso, o seu IMC é " + imc);
            }

            Console.ReadKey();
        }
    }
}
