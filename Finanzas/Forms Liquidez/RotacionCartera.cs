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
    public partial class RotacionCartera : Form
    {
        Liquidez RL;
        public RotacionCartera()
        {
            InitializeComponent();
            RL = new Liquidez();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = RL.RotacionCartera(RL.TextBox(TxtVentasCredito), RL.TextBox(TxtPromedio)).ToString();
            TxtDias.Text = (360 / RL.TextBox(TxtResultado)).ToString();
        }
    }
}
