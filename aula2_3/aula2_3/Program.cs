using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2_3 {
    class Program {
        static void Main(string[] args) {
            //Operacao oper = new Operacao();
            //oper.Calcular();
            ////Console.Read();

            //Soma sum = new Soma(10, 5);
            //sum.Calcular();
            ////Console.Read();

            //Produto prod = new Produto(5, 5);
            //prod.Calcular();
            //Console.Read();
            menu();
        }

        public static void menu() {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Multiplicação");
            int option = Console.Read();

            int v1 = 0;
            int v2 = 0;

            switch (option) {
                case (1):
                    Console.WriteLine("Introduza o 1º valor:");
                    v1 = Console.Read();                    
                    Console.WriteLine("Introduza o 2º valor:");
                    v2 = Console.Read();

                    Soma sum = new Soma(v1, v2);
                    sum.Calcular();
                    break;
                case (2):
                    Console.WriteLine("Introduza o 1º valor:");
                    v1 = Console.Read();                    
                    Console.WriteLine("Introduza o 2º valor:");
                    v2 = Console.Read();

                    Produto prod = new Produto(v1, v2);
                    prod.Calcular();
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
    }
}
