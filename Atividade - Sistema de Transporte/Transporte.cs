using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Transporte
{
    public abstract class Transporte
    {
        public abstract void CalcularTempoViagem(double distancia);

        public void IniciarViagem()
        {
            Console.WriteLine("Viagem iniciada...");
        }
    }
}