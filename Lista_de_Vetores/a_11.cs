  
using System;

class a_11
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        string resultado = Decodificar(entrada);
        Console.WriteLine(resultado);
    }

    static string Decodificar(string s)
    {
        string vogais = "aeiou";
        string saida = "";
        for (int i = 0; i < s.Length; i++)
        {
            saida += s[i];
            if (vogais.Contains(s[i].ToString()) && i + 2 < s.Length)
                i += 2;
        }
        return saida;
    }
}
