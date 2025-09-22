using System;
class a_05
{
    static void Main(string[] args)
    {
        Console.Write("Digite a sequência de DNA (até 50 bases): ");
        char[] dna = Console.ReadLine().ToUpper().ToCharArray();
        char[] comp = new char[dna.Length];
        for (int i = 0; i < dna.Length; i++)
        {
            if (dna[i] == 'A') comp[i] = 'T';
            else if (dna[i] == 'T') comp[i] = 'A';
            else if (dna[i] == 'C') comp[i] = 'G';
            else if (dna[i] == 'G') comp[i] = 'C';
        }
        Console.WriteLine("DNA original: " + new string(dna));
        Console.WriteLine("DNA complementar: " + new string(comp));
    }
}