using System;
class a_07
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho dos vetores: ");
        int n = int.Parse(Console.ReadLine());
        int[] v1 = new int[n];
        int[] v2 = new int[n];
        int[] v3 = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            v1[i] = rand.Next(1, 10);
            v2[i] = rand.Next(1, 10);
            v3[i] = v1[i] * v2[i];
        }
        Console.WriteLine("Vetor 1: " + string.Join(", ", v1));
        Console.WriteLine("Vetor 2: " + string.Join(", ", v2));
        Console.WriteLine("Vetor Resultante: " + string.Join(", ", v3));
    }
}
