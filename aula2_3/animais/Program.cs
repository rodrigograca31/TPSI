using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais {
    class Program {
        static Mamifero m;
        static Reptil r;
        static Ave a; 
        static void Main(string[] args) {
            bool notexit = false;
            int opt = 0;

            Console.WriteLine("Escolha o bicho:");
            Console.WriteLine("1 - Mamifero");
            Console.WriteLine("2 - Reptil");
            Console.WriteLine("3 - Ave");
            Console.WriteLine("0 - Sair");
            opt = int.Parse(Console.ReadLine());
            int peso = 0;
            int altura = 0;
            int nfome = 50;
            string som = "";
            switch (opt) {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Quanto pesa o seu bicho?");
                    peso = int.Parse(Console.ReadLine());
                    Console.WriteLine("Quanto mede o seu bicho?");
                    altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o som que o seu bicho faz?");
                    som = Console.ReadLine();
                    m = new Mamifero(peso, altura, nfome, som);
                    break;

                case 2:
                    Console.WriteLine("Quanto pesa o seu bicho?");
                    peso = int.Parse(Console.ReadLine());
                    Console.WriteLine("Quanto mede o seu bicho?");
                    altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o som que o seu bicho faz?");
                    som = Console.ReadLine();
                    r = new Reptil(peso, altura, nfome, som);
                    break;

                case 3:
                    Console.WriteLine("Quanto pesa o seu bicho?");
                    peso = int.Parse(Console.ReadLine());
                    Console.WriteLine("Quanto mede o seu bicho?");
                    altura = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o som que o seu bicho faz?");
                    som = Console.ReadLine();
                    a = new Ave(peso, altura, nfome, som);
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente de novo");
                    break;
            }
            Console.Clear();
            Console.WriteLine("Nivel de fome igual a {0}", nfome);
            Console.WriteLine("-------------------------------------------------");
            do {
                Console.WriteLine("Escolha uma ação:");
                Console.WriteLine("1 - Comer");
                Console.WriteLine("2 - Dormir");
                Console.WriteLine("3 - Movimentar");
                Console.WriteLine("0 - Sair");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opt) {
                    case 0:
                        notexit = true;
                        break;
                    case 1:
                        if (m != null) {
                            m.alimentar();
                            Console.WriteLine("Nivel de fome igual a {0}", m.showNivelFome());
                        }
                        else if (r != null) {
                            r.alimentar();
                            Console.WriteLine("Nivel de fome igual a {0}", r.showNivelFome());
                        }
                        else if (a != null) {
                            a.alimentar();
                            Console.WriteLine("Nivel de fome igual a {0}", a.showNivelFome());
                        }
                        break;
                    case 2:
                        if (m != null) {
                            m.dormir();
                            Console.WriteLine("Nivel de fome igual a {0}", m.showNivelFome());
                        }
                        else if (r != null) {
                            r.dormir();
                            Console.WriteLine("Nivel de fome igual a {0}", r.showNivelFome());
                        }
                        else if (a != null) {
                            a.dormir();
                            Console.WriteLine("Nivel de fome igual a {0}", a.showNivelFome());
                        }
                        break;
                    case 3:
                        if (m != null) {
                            m.mover();
                            Console.WriteLine("Nivel de fome igual a {0}", m.showNivelFome());
                        }
                        else if (r != null) {
                            r.mover();
                            Console.WriteLine("Nivel de fome igual a {0}", r.showNivelFome());
                        }
                        else if (a != null) {
                            a.mover();
                            Console.WriteLine("Nivel de fome igual a {0}", a.showNivelFome());
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente de novo");
                        break;
                }

                Console.WriteLine("-------------------------------------------------");
            } while (notexit == false);
        }
    }
}
