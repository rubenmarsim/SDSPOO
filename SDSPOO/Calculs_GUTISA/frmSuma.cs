using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculs_GUTISA
{
    public partial class frmSuma : Calculs.frmSuma
    {
        public frmSuma()
        {
            InitializeComponent();
        }
        public double Sumar(int intPercent)
        {
            double result;
            txtBoxTotal.Text = Sumar().ToString();
            result = double.Parse(txtBoxTotal.Text) + double.Parse(txtBoxTotal.Text) * intPercent / 100;
            return result;
        }

        private void btnSuma_Gutisa_Click(object sender, EventArgs e)
        {
            txtBoxTotal.Text = Sumar(int.Parse(txtBoxPercentatge.Text)).ToString();
        }
    }
}
