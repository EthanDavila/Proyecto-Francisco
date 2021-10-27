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
    public partial class CapitalTrabajo : Form
    {
        Liquidez RL;
        public CapitalTrabajo()
        {
            InitializeComponent();
            RL = new Liquidez();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Activo = Double.Parse(TxtActivos.Text);
            double Pasivo = Double.Parse(TxtPasivos.Text);
            TxtResultado.Text = RL.CapitalTrabajo(Activo, Pasivo).ToString();
        }
    }
}
