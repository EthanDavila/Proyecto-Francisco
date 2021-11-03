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
    public partial class RazonEndeudamiento : Form
    {
        Endeudamiento RE = new Endeudamiento();
        public RazonEndeudamiento()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = $"La empresa tiene un nivel de endeudamiento {RE.RazonEndeudamiento(Double.Parse(TxtPasivoTotal.Text), Double.Parse(TxtActivoTotal.Text)).ToString()} % frente sus activos esto quiere decir que el endeudamiento o el apalancamiento no es muy elevado ";
        }
    }
}
