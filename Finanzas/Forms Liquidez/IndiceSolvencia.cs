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
    public partial class IndiceSolvencia : Form
    {
        Liquidez RL;
        public IndiceSolvencia()
        {
            InitializeComponent();
            RL = new Liquidez();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Activo = Double.Parse(TxtActivos.Text);
            double Pasivo = Double.Parse(TxtPasivos.Text);
            TxtResultado.Text = $"La empresa cuenta con un índice de solvencia de {RL.IndiceSolvencia(Activo, Pasivo).ToString("N4")} por ende puede responder sus obligaciones sin afectar la solvencia";
        }
    }
}
