using System;

namespace estrutura_pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pilha();
            Console.WriteLine("Estrutura pilha em .NET usando C#");
            p.Empilhar("primeiro");
            p.Empilhar("segundo");
            p.Empilhar("Terceiro");
            // ##
            Console.WriteLine("Pos " + p.Desempilhar());
            Console.WriteLine("Pos " + p.Desempilhar());
            Console.WriteLine("Pos " +p.Desempilhar());
        }
    }
}
