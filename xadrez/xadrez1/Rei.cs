using tabuleiro;

namespace xadrez1
{
    class Rei : Peca {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString(){
            return "R";
        }
    }
}
