using System;

namespace ExFibonacci {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um numero inteiro: ");
            int number = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);

            int aux = 0;
            while (aux < number) {
                list.Add(list[aux] + list[aux+1]);
                aux++;
            }
            
            int pertence = list.Find(x => x == number);
            if (pertence == number) Console.WriteLine("Pertence a sequencia de Fibonacci");
            else Console.WriteLine("Nao pertence a sequencia de Fibonacci");
        }
    }
}