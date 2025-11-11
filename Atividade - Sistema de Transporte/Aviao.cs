using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Transporte
{
    public class Aviao : Transporte
    {
        public override void CalcularTempoViagem(double distancia)
        {
            //* A velocidade média do avião é 800 km/h
            double tempo = distancia / 800;
            Console.WriteLine($"O tempo estimado de viagem para {distancia} km é de {tempo} horas.");
        }
    }
}