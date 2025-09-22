using System;

class a_02
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];

        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            vetor[i] = rand.Next(1, 100);
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
