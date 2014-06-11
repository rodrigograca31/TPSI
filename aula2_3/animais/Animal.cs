using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais {
    class Animal {
        private int peso;
        private int altura;
        private int nivelFome; // (0..100%)
        private string sons;

        public int Peso {
            set {
                if (value > 0)
                    peso = value;
                else
                    throw new Exception("Peso não pode ser um valor negativo!");
            }
            get {
                return peso;
            }

        }

        public int Altura {
            set {
                if (value > 0)
                    altura = value;
                else
                    throw new Exception("Altura não pode ser um valor negativo!");
            }
            get {
                return altura;
            }

        }

        public int NivelFome {
            set {
                if ((value >= 0) && (value <= 100)){
                    nivelFome = value;
                }else if (value < 0){
                    nivelFome = 0;
                    throw new WarningException("O bicho está satisfeito");
                }
                else if (value > 100) {
                    throw new Exception("O bicho morreu de fome");
                }
            }
            get {
                return nivelFome;
            }

        }

        public string Sons {
            set {
                if (!string.IsNullOrEmpty(value))
                    sons = value;
                else
                    throw new Exception("O animal tem que ter um som!");
            }
            get {
                return sons;
            }

        }

        public Animal() {
        }

        public Animal(int Peso, int Altura, int NivelFome, string Sons) {
            this.Peso = Peso;
            this.Altura = Altura;
            this.NivelFome = NivelFome;
            this.Sons = Sons;
        }


        public virtual void alimentar() {
        }

        public virtual void mover() {
        }

        public virtual void dormir() {
        }

        public virtual void falar() {
        }

        public virtual int showNivelFome() {
            return NivelFome;
        }
    }
}
