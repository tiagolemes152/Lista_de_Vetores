using System;
class a_10
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de lançamentos: ");
        int n = int.Parse(Console.ReadLine());
        int[] resultados = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
            resultados[i] = rand.Next(1, 7);

        Console.WriteLine("Resultados: " + string.Join(", ", resultados));
        for (int face = 1; face <= 6; face++)
        {
            int count = 0;
            foreach (int r in resultados)
                if (r == face) count++;
            Console.WriteLine("Face " + face + ": " + count + " vezes");
        }
    }
}