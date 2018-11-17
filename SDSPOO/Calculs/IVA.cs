using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculs
{
    public class IVA
    {
        #region Properties
        private double _importe;
        public double propImporte
        {
            get { return _importe; }
            set { _importe = value; }
        }
        private int _iva;
        public int propIVA
        {
            get { return _iva; }
            set { _iva = value; }
        }
        private string _TipusIVA;
        public string propTipusIVA
        {
            get { return _TipusIVA; }
            set { _TipusIVA = value; }
        }
        #endregion

        public IVA()
        {
            this._importe = propImporte;
        }
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

        virtual public double Beneficis(double valorB)
        {
            double dResultadoBenefici = 0;
            dResultadoBenefici += valorB * 0.33;
            return dResultadoBenefici;
        }
    }
}
