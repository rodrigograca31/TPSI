using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais {
    class Program {
        static Animal animal;
        static void Main(string[] args) {
            bool notexit = false;
            int opt = 0;

            Console.WriteLine("Escolha o bicho:");
            Console.WriteLine("1 - Mamifero");
            Console.WriteLine("2 - Reptil");
            Console.WriteLine("3 - Ave");
            Console.WriteLine("0 - Sair.");
            opt = int.Parse(Console.ReadLine());
            int peso = 0;
            int altura = 0;
            int nfome = 50;
            string som = "";
            Console.WriteLine("Quanto pesa o seu bicho?");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto mede o seu bicho?");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o som que o seu bicho faz?");
            som = Console.ReadLine();

            switch (opt) {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    animal = new Mamifero(peso, altura, nfome, som);
                    break;
                case 2:
                    animal = new Reptil(peso, altura, nfome, som);
                    break;
                case 3:
                    animal = new Ave(peso, altura, nfome, som);
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente de novo");
                    break;
            }
            Console.Clear();
            Console.WriteLine("Nivel de fome igual a {0}", nfome);
            Console.WriteLine("-------------------------------------------------");
            
        }
    }
}
