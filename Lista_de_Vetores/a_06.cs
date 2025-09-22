using System;
class a_06
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
            vetor[i] = rand.Next(1, 101);

        Console.WriteLine("Vetor: " + string.Join(", ", vetor));
        Console.Write("Digite um número: ");
        int x = int.Parse(Console.ReadLine());
        bool achou = false;
        for (int i = 0; i < n; i++)
            if (vetor[i] == x)
            {
                Console.WriteLine("Número encontrado na posição: " + i);
                achou = true;
            }
        if (!achou) Console.WriteLine("Número não encontrado.");
    }
}