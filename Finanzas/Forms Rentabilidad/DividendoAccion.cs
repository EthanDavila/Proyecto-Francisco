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

namespace Finanzas.Forms_Rentabilidad
{
    public partial class DividendoAccion : Form
    {
        Rentabilidad RR = new Rentabilidad();
        public DividendoAccion()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = $"Cada acción brinda una utilidad de {RR.DividendoAccion(RR.TextBox(TxtDividendosPagados), RR.TextBox(TxtNo)).ToString()}";
        }
    }
}
