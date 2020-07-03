
using POO.Entidades;
using POO.Entidades.Base;
using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var moto = new Moto("Honda", "Titan");
            var carro = new Carro("hyundai", "HB20");
            
            Estacionar(moto, carro);
            
            Console.ReadKey();
        }
        /// <summary>
        /// Método polimórfico
        /// </summary>
        /// <param name="veiculos"></param>
        private static void Estacionar(params Veiculo[] veiculos)
        {
            foreach (var veiculo in veiculos)
            {
                if (!veiculo.On)
                    veiculo.Ligar();

                veiculo.Mover();
                veiculo.Mover();
                veiculo.Parar();
                veiculo.Desligar();
                Console.WriteLine($"{veiculo.Modelo} estacionado!");
            }
        }
    }
}
