using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caVentiladorDeTeto;


    namespace caVentiladorDeTeto
    {
    class Programa
    {
        static void Main(string[] args)
        {
            Pilha pilha = new Pilha();

            // Peças padrão do ventilador (da base para o topo)
            string[] pecas = new string[]
            {
            "Cúpula de Vidro",
            "Lâmpada",
            "Hélice",
            "Hélice Quebrada",
            "Suporte"
            };

            // Empilha as peças na ordem especificada
            foreach (var peca in pecas)
            {
                pilha.Empilhar(peca);
            }

            Console.WriteLine("Pilha original:");
            pilha.ImprimirPilha();

            Console.WriteLine("\nQual peça deseja substituir?");
            string pecaVelha = Console.ReadLine();

            Console.WriteLine("Qual é a nova peça para substituição?");
            string pecaNova = Console.ReadLine();

            // Realiza a substituição da peça
            pilha.SubstituirPeca(pecaVelha, pecaNova);

            Console.WriteLine("\nPilha após substituição:");
            pilha.ImprimirPilha();
            Console.ReadLine();
            Console.Clear();
        }
    }

}
