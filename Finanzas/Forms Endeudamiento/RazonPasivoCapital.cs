using Finanzas.Razones_Financieras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas.Forms_Endeudamiento
{
    public partial class RazonPasivoCapital : Form
    {
        Endeudamiento RE;
        public RazonPasivoCapital()
        {
            InitializeComponent();
            RE = new Endeudamiento();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = RE.RazonPasivoCapital(Double.Parse(TxtPasivoLP.Text), Double.Parse(TxtCapital.Text)).ToString();
        }
    }
}
