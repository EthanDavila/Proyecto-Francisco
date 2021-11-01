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
    public partial class RendimientoCapitalComun : Form
    {
        Rentabilidad RR = new Rentabilidad();
        public RendimientoCapitalComun()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = RR.RendimientoCapitalComun(RR.TextBox(TxtUDI), RR.TextBox(TxtDividendosPreferentes), RR.TextBox(TxtCapitalPreferente), RR.TextBox(TxtCapitalContable)).ToString();
        }
    }
}
