//Escreva um programa que leia ou gere um vetor de N elementosinteiros. A seguir, crie uma função que receba
//esse vetor e conte quantos valores impares existem no vetor. Retorne a quantidade de impares.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            vetor[i] = rand.Next(1, 100); // Gera números aleatórios entre 1 e 99
        }

        Console.WriteLine("Vetor gerado: " + string.Join(", ", vetor));

        int quantidadeImpares = ContarImpares(vetor);
        Console.WriteLine("Quantidade de valores ímpares no vetor: " + quantidadeImpares);
    }

    static int ContarImpares(int[] vetor)
    {
        int count = 0;
        foreach (int num in vetor)
        {
            if (num % 2 != 0)
            {
                count++;
            }
        }
        return count;
    }
}