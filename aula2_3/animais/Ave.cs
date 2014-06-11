using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais {
    class Ave:Animal {
        public Ave(){
        }

        public Ave(int peso, int altura, int nivelFome, string sons):base(peso, altura, nivelFome, sons){
        }

        public override void alimentar() {
            this.NivelFome -= Convert.ToInt32(this.NivelFome * 0.3);
        }

        public override void mover() {
            this.NivelFome += Convert.ToInt32(this.NivelFome * 0.02);
        }

        public override void dormir() {
            this.NivelFome -= Convert.ToInt32(this.NivelFome * 0.05);
        }
    }
}
