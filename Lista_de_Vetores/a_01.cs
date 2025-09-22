using System;
class a_01
{
    static void Main()
    {
        Console.WriteLine("Digite o tamanho do Vetor: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];
        Random rand = new Random();
        for (int i = 0; i < vetor.Length; i++)


        {
            vetor[i] = rand.Next(0, 100);
            Console.WriteLine("Elemento da posição " + i + " :" + vetor[i]);
        }

        int soma = somavetor(vetor);
        Console.WriteLine("A soma dos elementos do vetor é: " + soma);
    }

        static int somavetor(int[] vetor)
    {
        int soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        return soma;
    } 
    
}