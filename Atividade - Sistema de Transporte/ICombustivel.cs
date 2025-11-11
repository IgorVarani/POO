using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade___Sistema_de_Transporte
{
    public interface ICombustivel
    {
        public void Abastecer(double litros);

        public void VerificarNivelCombustivel();
    }
}