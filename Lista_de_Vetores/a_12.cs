using System;
using System.Linq;

class Program {
    static void Main() {
        float[] notas = Console.ReadLine().Split().Select(float.Parse).ToArray();
        Array.Sort(notas);
        float soma = notas[1] + notas[2] + notas[3];
        Console.WriteLine($"{soma:F1}");
    }
}
