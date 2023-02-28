using System;

namespace ExInverteString {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite uma palavra/frase: ");
            string str = Console.ReadLine();

            for (int i = str.Length - 1; i < str.Length && i >= 0; i--) {
                Console.Write(str[i]);
            }
        }
    }
}