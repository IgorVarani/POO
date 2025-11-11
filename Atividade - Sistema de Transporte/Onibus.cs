using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Transporte
{
    public class Onibus : Transporte
    {
        public override void CalcularTempoViagem(double distancia)
        {
            //* A velocidade média do busão é 60 km/h
            double tempo = distancia / 60;
            Console.WriteLine($"O tempo estimado de viagem para {distancia} km é de {tempo} horas.");
        }
    }
}