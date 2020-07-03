using System;

namespace POO.Entidades.Base
{
    //Utilizando abstração, objeto apenas pode usado como base para herança nunca para implementação.
    public abstract class Veiculo
    {
        public string Fabricante { get; private set; }
        public string Modelo { get; private set; }
        public bool On { get; private set; }

        protected Veiculo(string fabricante, string modelo)
        {
            //Encapsulando proriedades, garantindo que eventos externos,
            //não consiga alterar um valor da propriedade.
            //apenas o comportamento da instancia pode fazer isso
            Fabricante = fabricante;
            Modelo = modelo;
        }

        /// <summary>
        /// Encapsulando mecânica que faz o carro ligar
        /// </summary>
        public void Ligar()
        {

            if (!On)
            {
                Console.WriteLine($"Ligando... {Modelo}");
                On = true;
            }
        }
        /// <summary>
        /// Encapsulando mecânica que faz o carro desligar
        /// </summary>
        public void Desligar()
        {
            if (On)
            {
                Console.WriteLine($"Desligando... {Modelo}");
                On = false;
            }
        }
        public virtual void Mover()
        {
            if (On)
                Console.WriteLine($"Movendo... {Modelo}");
        }
        public virtual void Parar()
        {
            if (On)
                Console.WriteLine($"Parando... {Modelo}");
        }

    }
}
