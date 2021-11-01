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
    public partial class MBU : Form
    {
        Rentabilidad RR = new Rentabilidad();
        public MBU()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = RR.MargenBrutoUtilidad(RR.TextBox(TxtVentas), RR.TextBox(TxtCostoVentas)).ToString();
        }
    }
}
