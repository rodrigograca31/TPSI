using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2_3 {
    class Produto:Operacao {
        public Produto() {
        }

        public Produto(int vA, int vB): base(vA, vB) {
        }

        public override void Calcular() {
            Console.WriteLine("{0}*{1}={2}", ValorA, ValorB, ValorA * ValorB);
        }
    }
}
