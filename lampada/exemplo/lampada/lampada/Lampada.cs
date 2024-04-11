using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lampada
{
    public class Lampada
    {
        private bool ligada { get; set; }
        private string? Cor { get; set; }
        private int Potencia { get; set; }
        
        public void ligar()
        {
            ligada = true;
        }
        public void desligar()
        {
            ligada = false;
        }
        public bool estaligada()
        {
            return ligada;
        }
    }
}
