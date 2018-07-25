namespace Imoveis.Domain
{
    public abstract class Imovel
    {
        public string Cor { get; protected set; }
        
        public void Pinta(string cor)
        {
            Cor = cor;
        }

        public abstract int QuantasPortasEstaoAbertas();

        public abstract int TotalDePortas();

    }
}