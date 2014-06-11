using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais {
    class Mamifero:Animal {
        public Mamifero(){
        }

        public Mamifero(int peso, int altura, int nivelFome, string sons):base(peso, altura, nivelFome, sons){
        }

        public override void alimentar() {
            this.NivelFome /= 2;
        }

        public override void mover() {
            this.NivelFome += Convert.ToInt32(this.NivelFome * 0.1);
        }

        public override void dormir() {
            this.NivelFome -= Convert.ToInt32(this.NivelFome * 0.02);
        }

        /*public override void falar() {
        }

        public override void showNivelFome() {
        }*/
    }
}

