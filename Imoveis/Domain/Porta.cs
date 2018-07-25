using System;

namespace Imoveis.Domain
{
    public class Porta
    {
        private bool Aberta { get; set; }
        public string Cor { get;private set; }
        public double DimensaoX { get; set; }
        public double DimensaoY { get; set; }
        public double DimensaoZ { get; set; }

        public void Abre()
        {
            Aberta = true;
        }
        public void Fecha()
        {
            Aberta = false;
        }

        public void Pinta(string cor)
        {
            Cor = cor;
        }

        public bool EstaAberta()
        {
            return Aberta;
        }
        
    }
}