using System;

namespace ordenação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[10];
            int aux = 0;
            // Armazenando os valores
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Digite o " + (a + 1) + "° valor");
                valor[a] = int.Parse(Console.ReadLine());
            }
            // Invertendo os valores
            for (int a = 0; a < 10; a++)
            {
                for (int b = a+1; b < 10; b++)
                {
                    if (valor[a] > valor[b])
                    {
                        aux = valor[b];
                        valor[b] = valor[a];
                        valor[a] = aux;
                    }
                }
            }
            Console.Clear();
            // Executando os valores
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine(valor[a] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(true);
        }
    }
}
