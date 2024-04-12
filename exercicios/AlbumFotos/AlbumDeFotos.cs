using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    class AlbumDeFotos
    {
        public int NumeroTotalDePaginas { get; set; } 
        public int NumeroTotalDeFotos { get; set; }

        private int numeroDeFotos;

        public int NumeroDeFotos {
            get
            {
                return numeroDeFotos;
            }
            set 
            {
                if (value > NumeroTotalDeFotos)
                {
                    Console.WriteLine("Erro, número de fotos muito alto");
                }
                else
                {
                    numeroDeFotos = value;
                }
            }
        }

        public void DefinirAlbum(int totalP, int fotos)
        {
            NumeroTotalDePaginas = totalP;
            NumeroTotalDeFotos = totalP * 2;
            NumeroDeFotos = fotos;
            Console.WriteLine($"Número Total de Páginas: {NumeroTotalDePaginas}");
            Console.WriteLine($"Número Total de Fotos: {NumeroTotalDeFotos}");
            Console.WriteLine($"Número de Páginas: {NumeroDeFotos}");
        }

    }
}
