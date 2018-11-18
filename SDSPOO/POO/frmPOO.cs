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

        private List<string> oListGetItems()
        {
            var oListItems = new List<string>();
            oListItems.Add("Catalan");
            oListItems.Add("Castellano");
            oListItems.Add("Ingles");
            return oListItems;
        }

        private void Load_oListGetItems()
        {
            int id = 0;
            foreach (string items in oListGetItems())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(items);
                menuStrip1.Items.Add(item);
                item.Tag = id;
                id++;
                item.Click += new EventHandler(Item_Click);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item.Text.Equals("Catalan"))
            {
                MessageBox.Show("Benvinguts a la Programació Orientada a Objectes");
            }
            else if (item.Text.Equals("Castellano"))
            {
                MessageBox.Show("Bienvenidos a la Programación Orientada a Objetos");
            }
            else if (item.Text.Equals("Ingles"))
            {
                MessageBox.Show("Welcome to Object Oriented Programming");
            }
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

        }

        private void btnCalculaIVA1_Click(object sender, EventArgs e)
        {
            txtBoxValorIVA1.Text = CCalculs.CalculaIVA(double.Parse(txtBoxImport.Text)).ToString();
        }

        private void btnCalculaIVA2_Click(object sender, EventArgs e)
        {
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
        private void btnBenvinguda_Click(object sender, EventArgs e)
        {
            Load_oListGetItems();
        }
    }
}
