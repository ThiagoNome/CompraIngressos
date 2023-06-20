using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraIngressos.Controller
{
    internal class Ingressos
    {
        private int num;
        public int Calculo(int Quantidade, int Valor) {

            num = Quantidade * Valor;

            return num; 
        }
    }
}
