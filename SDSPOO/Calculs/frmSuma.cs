using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculs
{
    public partial class frmSuma : Form
    {
        public frmSuma()
        {
            InitializeComponent();
        }

        public int Sumar()
        {
            int result;
            result = int.Parse(txtBoxNum1.Text) + int.Parse(txtBoxNum2.Text);
            return result;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtBoxTotal.Text = Sumar().ToString();
        }
    }
}
