using Finanzas.Forms;
using Finanzas.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas
{
    public partial class Main : Form
    {
        public DatosBalanceGeneral datosBalanceGeneral;
        public Main()
        {
            InitializeComponent();
            datosBalanceGeneral = new DatosBalanceGeneral();
        }

        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceGeneral Form = new BalanceGeneral();
            Form.MdiParent = this;
            Form.datosBalanceGeneral = datosBalanceGeneral;
            Form.Show();
        }
    }
}
