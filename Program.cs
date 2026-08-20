using System.Collections.Generic;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numeros = [];
            int multi = 1;

            while (true)
            {
                Console.WriteLine("Digite um número (0 para sair): ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                    break;
                Numeros.Add(num);
            }

            foreach (int i in Numeros)
            {
                multi *= i;

            }

            int maior = Numeros.Max();
            int menor = Numeros.Min();

            Numeros.Sort();
            Console.WriteLine($"Números em ordem: {string.Join(", ", Numeros)}");

            Console.WriteLine($"Números multiplicados: {multi}");

            Console.WriteLine($"Número maior: {maior}");

            Console.WriteLine($"Número menor: {menor}");
        }
    }
}
