using System;
using System.Collections.Generic;
namespace Secao_6_Exe_Conjunto_Hashset_aula_82
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3); A.Add(5); A.Add(8); A.Add(9);

            B.Add(3); B.Add(4); B.Add(5); B.Add(4); //um conjunto não aceita valores repetidos

            // B.Remove(Valor desejado) para remover algum elemento contido no conjunto

            Console.WriteLine("Conjuto A: ");
            foreach (int x in A)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\nConjuto B:");
            foreach (int y in B)
            {
                Console.Write(y + " ");
            }
            //TESTANDO AGORA A UNIÃO DOS ELEMENTOS CONTIDOS NOS CONJUNTOS

            A.UnionWith(B);
            Console.WriteLine("\nConjuto A + B: ");
            foreach (int u in A)
            {
                Console.Write(u + " ");
            }

            //TESTANDO A INTERSECÇÃO DOS CONJUNTOS
            A.IntersectWith(B);
            Console.WriteLine("\nConjuto A Intercecção B: ");
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nDigite um valor inteiro para verificar o conjunto B: ");
            int n = int.Parse(Console.ReadLine());

            if (B.Contains(n))//vai verificar se no conjunto b contém o valor de n que digitado pelo usuário
            {
                Console.WriteLine(n + " Pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine(n + " Não contém no conjunto B");
            }
            //TESTANDO A DIFERENÇA ESTA OPERAÇÃO FAZ COM QUE TODO ELEMENTO CONTIDO EM UM CONJUNTO SEJA REMOVIDO DO OUTRO

            A.ExceptWith(B); //foi dada a operação para remover de A o que contém em B

            Console.WriteLine("Conjuto A: ");
            foreach (int e in A)
            {
                Console.Write(e + " ");
            }
        }
    }
}
