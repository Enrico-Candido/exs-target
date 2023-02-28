using System;

namespace ExFaturamentoMensal {
    class Program {
        static void Main(string[] args) {
            List<Unidade> list = new List<Unidade>();
            list.Add(new Unidade("SP", 67836.43));
            list.Add(new Unidade("RJ", 36678.66));
            list.Add(new Unidade("MG", 29229.88));
            list.Add(new Unidade("ES", 27165.48));
            list.Add(new Unidade("Outros", 19849.53));

            double somaTotal = 0;
            foreach (Unidade unidade in list) {
                somaTotal += unidade.ValorArrecadado;
            }

            foreach (Unidade unidade in list) {
                double percentual = unidade.ValorArrecadado * 100 / somaTotal;
                Console.WriteLine($"Local: {unidade.Local}, valor arrecadado em percentual por unidade: {percentual:F2}%");
                Console.WriteLine();
            }

        }
    }
}
