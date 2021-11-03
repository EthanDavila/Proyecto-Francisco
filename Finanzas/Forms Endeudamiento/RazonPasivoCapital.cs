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
            if (RE.RazonPasivoCapital(Double.Parse(TxtPasivoLP.Text), Double.Parse(TxtCapital.Text)) > 1)
            {
                TxtResultado.Text = $"La empresa se encuentra financiada en mayor medida por terceros lo que se traduce mayor autonomía financiera con un mayor apalancamiento financiero";
            }
            else
            {
                TxtResultado.Text = $"El financiamiento proviene de mayor medida  de los socios";
            }
            
        }
    }
}
