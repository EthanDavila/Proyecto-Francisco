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
    public partial class RotacionInventario : Form
    {
        Liquidez RL;
        public RotacionInventario()
        {
            InitializeComponent();
            RL = new Liquidez();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = $"Los inventarios se vendieron cada {12 / RL.RotacionInventario(RL.TextBox(TxtCostoMercanciaVendida), RL.TextBox(TxtPromedioInventario))} meses por ende se concluye que del inventario duro ---- meses en la bodega antes de ser vendido.";
        }
    }
}
