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
    public partial class PruebaAcida : Form
    {
        Liquidez RL = new Liquidez();
        public PruebaAcida()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = RL.PruebaAcida(Double.Parse(TxtActivos.Text), Double.Parse(TxtInventario.Text), Double.Parse(TxtPasivos.Text)).ToString();
        }
    }
}
