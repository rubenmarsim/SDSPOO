using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs
{
    public class IVA
    {
        private double _importe;

        public double Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        //public PasarValores(double importe)
        //{
        //    importe = 
        //}
        public double CalculaIVA(double valorX)
        {
            double dResultadoIVA = 0;
            dResultadoIVA += valorX * 0.21;
            return dResultadoIVA;
        }

        public double CalculaIVA(double valorX, int valorY)
        {
            double dResultadoIVA = 0;
            dResultadoIVA += valorX * (valorY / 100);
            return dResultadoIVA;
        }

        public double Beneficis(double valorB)
        {
            double dResultadoBenefici = 0;
            dResultadoBenefici += valorB * 0.33;
            return dResultadoBenefici;
        }
    }
}
