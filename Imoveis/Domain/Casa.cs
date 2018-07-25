namespace Imoveis.Domain
{
    public class Casa:Imovel
    {
        public Porta Porta1 { get; set; }
        public Porta Porta2 { get; set; }
        public Porta Porta3 { get; set; }
        
        public Casa(Porta porta1, Porta porta2, Porta porta3)
        {
            Porta1 = porta1;
            Porta2 = porta2;
            Porta3 = porta3;
        }
        public override int QuantasPortasEstaoAbertas()
        {
            var count = 0;
            if(Porta1.EstaAberta()) count++;
            if(Porta2.EstaAberta()) count++;
            if(Porta3.EstaAberta()) count++;
            return count;
        }
        public override int TotalDePortas()
        {
            return 3;
        }
    }
}