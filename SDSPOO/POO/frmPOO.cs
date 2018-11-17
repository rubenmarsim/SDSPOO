﻿using System;
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
        Calculs.frmSuma CalculsfrmSuma = new Calculs.frmSuma();
        CGutisa.frmSuma CalculsfrmSuma_Gutisa = new CGutisa.frmSuma();
        Saluda CSaluda = new Benvinguda.Saluda();
        public frmPOO()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            CalculsfrmSuma.Show();
        }

        private void btnSumaGutisa_Click(object sender, EventArgs e)
        {
            CalculsfrmSuma_Gutisa.Show();
        }
    }
}
