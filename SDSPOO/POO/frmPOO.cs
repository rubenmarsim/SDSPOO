using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculs;
using CGutisa = Calculs_GUTISA;
using Benvinguda;

namespace POO
{
    public partial class frmPOO : Form
    {
        
        public frmPOO()
        {
            InitializeComponent();
        }

        #region Instancias
        Calculs.frmSuma CalculsfrmSuma = new Calculs.frmSuma();
        Calculs.IVA CCalculs = new Calculs.IVA();
        CGutisa.frmSuma CalculsfrmSuma_Gutisa = new CGutisa.frmSuma();
        Saluda CSaluda = new Benvinguda.Saluda();
        #endregion

        #region Metodos

        public void PasarValoresaProps()
        {
            CCalculs.propImporte = double.Parse(txtBoxImport.Text);
            CCalculs.propIVA = int.Parse(txtBoxIVA.Text);
            //CalculsfrmSuma_Gutisa.CalculaIVA = 
        }

        #endregion

        private void btnSuma_Click(object sender, EventArgs e)
        {
            CalculsfrmSuma.Show();
        }

        private void btnSumaGutisa_Click(object sender, EventArgs e)
        {
            CalculsfrmSuma_Gutisa.Show();
        }

        private void frmPOO_Load(object sender, EventArgs e)
        {

            CCalculs.propTipusIVA = txtBoxTipusIVA.Text;
        }

        private void btnCalculaIVA1_Click(object sender, EventArgs e)
        {
            PasarValoresaProps();
            CCalculs.CalculaIVA(double.Parse(txtBoxImport.Text));
        }

        private void btnCalculaIVA2_Click(object sender, EventArgs e)
        {
            PasarValoresaProps();
            CCalculs.CalculaIVA(double.Parse(txtBoxImport.Text), int.Parse(txtBoxIVA.Text));
        }
    }
}
