using POO.Entidades.Base;

namespace POO.Entidades
{
    public sealed class Carro : Veiculo
    {
        //Utilizando Herança 
        public Carro(string fabricante, string modelo) : base(fabricante, modelo)
        {
        }
        
    }
}
