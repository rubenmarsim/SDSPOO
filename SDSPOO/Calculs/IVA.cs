using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs
{
    public class IVA
    {
        public double CalculaIVA(double importe)
        {
            double dResultadoIVA = 0;
            dResultadoIVA = importe * 0.21;
            return dResultadoIVA;
        }

        public double CalculaIVA(double importe, int PorcentajeIVA)
        {
            double dResultadoIVA = 0;
            dResultadoIVA = importe * PorcentajeIVA / 100;
            return dResultadoIVA;
        }

        virtual public double Beneficis(double importe)
        {
            double dResultadoBenefici = 0;
            dResultadoBenefici = importe * 0.33;
            return dResultadoBenefici;
        }
    }
}
