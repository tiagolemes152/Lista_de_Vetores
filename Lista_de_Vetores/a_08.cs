using System;
class a_08
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
            vetor[i] = rand.Next(1, 10);

        Console.WriteLine("Vetor: " + string.Join(", ", vetor));
        Console.Write("Digite o valor a procurar: ");
        int x = int.Parse(Console.ReadLine());
        int count = 0;
        foreach (int num in vetor)
            if (num == x) count++;
        Console.WriteLine("O valor aparece " + count + " vezes.");
    }
}
