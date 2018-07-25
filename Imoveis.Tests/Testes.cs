using Imoveis.Domain;
using NUnit.Framework;

namespace Imoveis.Tests
{
    public class Testes
    {
    //A
        [Test]
        public void Teste_De_Porta()
        {
            var porta = new Porta();
            porta.Abre();
            porta.Fecha();
            
            porta.Pinta("Amarelo");
            porta.Pinta("Azul"); 
            porta.Pinta("Verde");

            porta.DimensaoX = 50.4;
            porta.DimensaoY = 200.0;
            porta.DimensaoZ = 10.2;

            Assert.AreEqual(porta.EstaAberta(), false);
            Assert.AreEqual(porta.Cor, "Verde");
        }
        
        //B
        [Test]
        public void Teste_De_Casa()
        {
            var porta1 = new Porta();
            var porta2 = new Porta();
            var porta3 = new Porta();
            var casa = new Casa(porta1, porta2, porta3);
            
            casa.Pinta("Amarelo");
            casa.Pinta("Azul"); 

            casa.Porta1.Abre();
            casa.Porta1.Fecha();
            
            casa.Porta2.Abre();
            
            casa.Porta3.Abre();

            Assert.AreEqual(casa.QuantasPortasEstaoAbertas(), 2);
            Assert.AreEqual(casa.Cor, "Azul");
        }
        
        //C (esse ehDificil)
        [Test]
        public void Teste_De_Edificil()
        {
            var edificio = new Edificio();
            
            edificio.Pinta("Azul"); 
            edificio.Pinta("Amarelo");
            
            var porta1 = new Porta();
            var porta2 = new Porta();
            var porta3 = new Porta();
            var porta4 = new Porta();
            var porta5 = new Porta();
            var porta6 = new Porta();
            
            edificio.AdicionaPorta(porta1);
            edificio.AdicionaPorta(porta2);
            edificio.AdicionaPorta(porta3);
            edificio.AdicionaPorta(porta4);
            edificio.AdicionaPorta(porta5);
            edificio.AdicionaPorta(porta6);
            
            porta1.Abre();
            porta2.Abre();
            
            edificio.AdicionarAndar();
            edificio.AdicionarAndar();
            edificio.AdicionarAndar();
            edificio.AdicionarAndar();

            Assert.AreEqual(edificio.QuantasPortasEstaoAbertas(), 2);
            Assert.AreEqual(edificio.TotalDeAndar(), 4);
            Assert.AreEqual(edificio.Cor, "Amarelo");
        }
    }
}