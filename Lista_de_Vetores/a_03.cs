using System;

class a_03
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        double[] vetor = new double[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
            vetor[i] = rand.NextDouble() * 100;

        Console.WriteLine("Vetor: " + string.Join(", ", vetor));
        double menor = MenorElemento(vetor);
        Console.WriteLine("Menor elemento: " + menor);
    }

    static double MenorElemento(double[] v)
    {
        double menor = v[0];
        foreach (double num in v)
            if (num < menor) menor = num;
        return menor;
    }
}