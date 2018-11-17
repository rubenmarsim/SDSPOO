using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class frmPOO : Form
    {
        Calculs.frmSuma CalculsfrmSuma = new Calculs.frmSuma();
        public frmPOO()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            CalculsfrmSuma.Show();
        }
    }
}
