using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        string[,] matriz = new string[n, 2];
        int resposta = 0;

        for (int i = 0; i < n; i++) {
            var p = Console.ReadLine().Split();
            matriz[i, 0] = p[0];
            matriz[i, 1] = p[1];

            for (int j = 0; j < i; j++) {
                if (matriz[j, 0] == matriz[i, 0] && matriz[j, 1] == matriz[i, 1]) {
                    resposta = 1;
                    break;
                }
            }
        }

        Console.WriteLine(resposta);
    }
}
