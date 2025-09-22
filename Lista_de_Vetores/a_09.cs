using System;
class a_09
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma sequência de caracteres: ");
        char[] vetor = Console.ReadLine().ToCharArray();
        Console.WriteLine("Tamanho do vetor: " + vetor.Length);
        Array.Reverse(vetor);
        Console.WriteLine("Vetor invertido: " + new string(vetor));
    }
}