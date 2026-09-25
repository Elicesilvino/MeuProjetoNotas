using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. ARRAY: Notas das provas principais (tamanho fixo de 2 posições)
        double[] notasProvas = { 7.5, 8.0 };

        // 2. LIST<T>: Notas dos trabalhos extras (tamanho dinâmico)
        List<double> notasTrabalhos = new List<double>();
        notasTrabalhos.Add(1.0); // Adiciona trabalho extra
        notasTrabalhos.Add(0.5); // Adiciona outro trabalho extra
        notasTrabalhos.Add(2.0); // Adicionamos mais um trabalho extra!

        // 3. CHAMADA DA FUNÇÃO
        ExibirRelatorio(notasProvas, notasTrabalhos);
    }

    // 4. FUNÇÃO (MÉTODO)
    static void ExibirRelatorio(double[] provas, List<double> trabalhos)
    {
        double somaTotal = 0;

        // Somando notas do Array
        foreach (double nota in provas)
        {
            somaTotal += nota;
        }

        // Somando notas da Lista
        foreach (double nota in trabalhos)
        {
            somaTotal += nota;
        }

        // Exibindo no console
        Console.WriteLine($"Quantidade de provas fixas (Array): {provas.Length}");
        Console.WriteLine($"Quantidade de trabalhos extras (List): {trabalhos.Count}");
        Console.WriteLine($"Nota final acumulada: {somaTotal}");
    }
}