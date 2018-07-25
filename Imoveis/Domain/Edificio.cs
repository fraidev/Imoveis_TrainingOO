using System.Collections.Generic;
using System.Linq;

namespace Imoveis.Domain
{
    public class Edificio:Imovel
    {
        private int TotalDeAndares { get; set; } = 0;
        private IList<Porta> Portas { get; set; } = new List<Porta>();
        
        public override int QuantasPortasEstaoAbertas()
        {
            return Portas.Count(x => x.EstaAberta());
        }
        public override int TotalDePortas()
        {
            return Portas.Count;
        }
        public void AdicionaPorta(Porta porta)
        {
            Portas.Add(porta);
        }
        /*public int GetTotalDePortas()
        {
            return Portas.Count;
        }*/
        public void AdicionarAndar()
        {
            TotalDeAndares++;
        }
        public int TotalDeAndar()
        {
            return TotalDeAndares;
        }
    } 
}