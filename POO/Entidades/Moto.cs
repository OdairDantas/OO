using POO.Entidades.Base;

namespace POO.Entidades
{
    public class Moto : Veiculo
    {
        //Utilizando Herança 
        public Moto(string fabricante, string modelo) : base(fabricante, modelo)
        {
        }
    }
}
