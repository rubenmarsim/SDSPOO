using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculs;

namespace Calculs_GUTISA
{
    public class IVA : Calculs.IVA
    {
        public double CalculaIVA(double importe, string TipusIVA)
        {
            double dResultadoIVA = 0;
            if (TipusIVA.Equals("N"))
            {
                dResultadoIVA = importe * 0.21;
            }
            else if (TipusIVA.Equals("R"))
            {
                dResultadoIVA = importe * 0.12;
            }
            else if (TipusIVA.Equals("SR"))
            {
                dResultadoIVA = importe * 0.07;
            }
            return dResultadoIVA;
        }
        public override double Beneficis(double importe)
        {

            return base.Beneficis(importe);
        }
        //public double BeneficisNormals()
        //{

        //}
    }
}
