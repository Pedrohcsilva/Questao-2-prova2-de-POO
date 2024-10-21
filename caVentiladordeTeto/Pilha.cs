using System;
using System.Collections.Generic;

public class Pilha
{
    private Stack<string> pilhaInterna;

    public Pilha()
    {
        pilhaInterna = new Stack<string>();
    }

    // Método para empilhar uma peça
    public void Empilhar(string peca)
    {
        pilhaInterna.Push(peca);
    }

    // Método para desempilhar uma peça
    public string Desempilhar()
    {
        return pilhaInterna.Pop();
    }

    // Método para substituir uma peça velha por uma nova
    public void SubstituirPeca(string pecaVelha, string pecaNova)
    {
        Stack<string> pilhaTemporaria = new Stack<string>();
        bool encontrada = false;

        // Remove as peças até encontrar a peça a ser substituída
        while (pilhaInterna.Count > 0)
        {
            string pecaAtual = pilhaInterna.Peek();
            if (pecaAtual.Equals(pecaVelha, StringComparison.OrdinalIgnoreCase))
            {
                pilhaInterna.Pop(); // Remove a peça velha
                pilhaInterna.Push(pecaNova); // Insere a peça nova
                encontrada = true;
                break;
            }
            else
            {
                pilhaTemporaria.Push(pilhaInterna.Pop()); // Armazena as peças removidas temporariamente
            }
        }

        if (!encontrada)
        {
            Console.WriteLine("Peça não encontrada na pilha.");
        }

        // Reinsere as peças removidas de volta na pilha
        while (pilhaTemporaria.Count > 0)
        {
            pilhaInterna.Push(pilhaTemporaria.Pop());
        }
    }

    // Método para imprimir o estado atual da pilha
    public void ImprimirPilha()
    {
        Console.WriteLine("Estado atual da pilha (do topo para a base):");
        foreach (string peca in pilhaInterna)
        {
            Console.WriteLine(peca);
        }
    }
}

