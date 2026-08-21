using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Perguntas = ["Telefonou para a vítima?", "Esteve no local do crime?", "Mora perto da vítima?", "Devia para a vítima?", "Já trabalhou com a vítima?"];
            List<bool> Sim = [];
            List<bool> Nao = [];

            foreach (string percorrer in Perguntas)
            {
                while (true)
                {
                    Console.WriteLine("Responda com [S/N]: ");
                    Console.WriteLine(percorrer);
                    string resposta = Console.ReadLine().ToLower();

                    if (resposta == "s")
                    {
                        Sim.Add(true);
                        break;
                    }

                    else if (resposta == "n")
                    {
                        Nao.Add(false);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Resposta inválida\n");

                    }
                }
            }

            if (Sim.Count() == 0 || Sim.Count() == 1)
                Console.WriteLine("Inocente");
            else if (Sim.Count() == 2)
                Console.WriteLine("Suspeito");
            else if (Sim.Count() == 3 || Sim.Count() == 4)
                Console.WriteLine("Cúmplice");
            else
                Console.WriteLine("Assassino");
        }
    }
}
