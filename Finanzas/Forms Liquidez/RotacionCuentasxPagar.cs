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

namespace Finanzas.Forms_Liquidez
{
    public partial class RotacionCuentasxPagar : Form
    {
        Liquidez RL;
        public RotacionCuentasxPagar()
        {
            InitializeComponent();
            RL = new Liquidez();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = $"La empresa tarda {(360 / RL.RotacionCuentasxPagarCortoPlazo(RL.TextBox(TxtComprasCredito), RL.TextBox(TxtPromedio))).ToString()} días en pagar sus obligaciones";
        }
    }
}
