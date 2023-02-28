using System;

namespace ExFaturamentoDiario {
    class Program {
        static void Main(string[] args) {
            Dados[] vet = new Dados[30];
            vet[0] = new Dados(1, 22174.1664);
            vet[1] = new Dados(2, 24537.6698);
            vet[2] = new Dados(3, 26139.6134);
            vet[3] = new Dados(4, 0.0);
            vet[4] = new Dados(5, 0.0);
            vet[5] = new Dados(6, 26742.6612);
            vet[6] = new Dados(7, 0.0);
            vet[7] = new Dados(8, 42889.2258);
            vet[8] = new Dados(9, 46251.174);
            vet[9] = new Dados(10, 11191.4722);
            vet[10] = new Dados(11, 0.0);
            vet[11] = new Dados(12, 0.0);
            vet[12] = new Dados(13, 3847.4823);
            vet[13] = new Dados(14, 373.7838);
            vet[14] = new Dados(15, 2659.7563);
            vet[15] = new Dados(16, 48924.2448);
            vet[16] = new Dados(17, 18419.2614);
            vet[17] = new Dados(18, 0.0);
            vet[18] = new Dados(19, 0.0);
            vet[19] = new Dados(20, 35240.1826);
            vet[20] = new Dados(21, 43829.1667);
            vet[21] = new Dados(22, 18235.6852);
            vet[22] = new Dados(23, 4355.0662);
            vet[23] = new Dados(24, 13327.1025);
            vet[24] = new Dados(25, 0.0);
            vet[25] = new Dados(26, 0.0);
            vet[26] = new Dados(27, 25681.8318);
            vet[27] = new Dados(28, 1718.1221);
            vet[28] = new Dados(29, 13220.495);
            vet[29] = new Dados(30, 8414.61);

            double menor = 0;
            double maior = 0;
            double soma = 0;
            for (int i = 0; i < 30; i++) {
                if (menor > vet[i].Valor) menor = vet[i].Valor;
                if (maior < vet[i].Valor) maior = vet[i].Valor;
                soma += vet[i].Valor;
            }
            double media = soma / 30;

            int acumula = 0;
            for (int i = 0; i < 30; i++) {
                if (vet[i].Valor > media) acumula++;
            }

            Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês foi: " + menor);
            Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês foi: " + maior);
            Console.WriteLine("O numero de dias que ultrapassou a media mensal foi de: " + acumula + " dias");
        }
    }
}