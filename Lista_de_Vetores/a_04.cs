using System;
class a_04
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
        double maior = MaiorElemento(vetor);
        Console.WriteLine("Maior elemento: " + maior);
    }

    static double MaiorElemento(double[] v)
    {
        double maior = v[0];
        foreach (double num in v)
            if (num > maior) maior = num;
        return maior;
    }
}
