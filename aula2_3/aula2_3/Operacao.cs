using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2_3 {
    class Operacao {
        private int valorA;
        private int valorB;

        public int ValorA {
            set {
                if (value > 0)
                    valorA = value;
                else
                    throw new Exception("Introduza um valor maior que ZERO!");
            }
            get {
                return valorA;
            }
        }

        public int ValorB {
            set {
                if (value > 0)
                    valorB = value;
                else
                    throw new Exception("Introduza um valor maior que ZERO!");
            }
            get {
                return valorB;
            }
        }

        /// <summary>
        /// Construtor que inicializa todos os atributos
        /// </summary>
        /// <param name="vA">1º Valor</param>
        /// <param name="vB">2º Valor</param>
        public Operacao(int vA, int vB) {
            this.ValorA = vA;
            this.ValorB = vB;
        }

        /// <summary>
        /// Instancia o objecto
        /// </summary>
        public Operacao() {
        }

        public virtual void Calcular() {
            Console.WriteLine("Calculo o que?");
        }
    }
}
