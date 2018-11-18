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
        CGutisa.IVA CCalculs_Gutisa = new CGutisa.IVA();
        Saluda CSaluda = new Benvinguda.Saluda();
        #endregion

        #region Metodos

        //public void PasarValoresaProps()
        //{
        //    CCalculs.propImporte = double.Parse(txtBoxImport.Text);
        //    CCalculs.propIVA = int.Parse(txtBoxIVA.Text);
        //    //CalculsfrmSuma_Gutisa.CalculaIVA = 
        //}

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

            //CCalculs.propTipusIVA = txtBoxTipusIVA.Text;
        }

        private void btnCalculaIVA1_Click(object sender, EventArgs e)
        {
            //PasarValoresaProps();
            txtBoxValorIVA1.Text = CCalculs.CalculaIVA(double.Parse(txtBoxImport.Text)).ToString();
        }

        private void btnCalculaIVA2_Click(object sender, EventArgs e)
        {
            //PasarValoresaProps();
            txtBoxValorIVA2.Text = CCalculs.CalculaIVA(double.Parse(txtBoxImport.Text), int.Parse(txtBoxIVA.Text)).ToString();
        }

        private void btnCalculaIVA3_Click(object sender, EventArgs e)
        {
            txtBoxValorIVA1.Text = CCalculs_Gutisa.CalculaIVA(double.Parse(txtBoxImport.Text)).ToString();
            txtBoxValorIVA2.Text = CCalculs_Gutisa.CalculaIVA(double.Parse(txtBoxImport.Text), int.Parse(txtBoxIVA.Text)).ToString();
            txtBoxValorIVA3.Text = CCalculs_Gutisa.CalculaIVA(double.Parse(txtBoxImport.Text), txtBoxTipusIVA.Text).ToString();
        }

        private void btnBeneficis_Click(object sender, EventArgs e)
        {
            txtBoxBeneficis.Text = CCalculs.Beneficis(double.Parse(txtBoxImport.Text)).ToString();
        }

        private void btnBeneficis2_Click(object sender, EventArgs e)
        {
            txtBoxBeneficis.Text = CCalculs_Gutisa.BeneficisNormals(double.Parse(txtBoxImport.Text)).ToString();
            txtBoxBeneficis2.Text = CCalculs_Gutisa.Beneficis(double.Parse(txtBoxImport.Text)).ToString();
        }
    }
}
