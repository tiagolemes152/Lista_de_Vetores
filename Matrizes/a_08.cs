using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        var set = new HashSet<string>();
        int resposta = 0;
        for (int i = 0; i < n; i++) {
            var p = Console.ReadLine().Split();
            string chave = p[0] + "," + p[1];
            if (set.Contains(chave)) resposta = 1;
            set.Add(chave);
        }
        Console.WriteLine(resposta);
    }
}
