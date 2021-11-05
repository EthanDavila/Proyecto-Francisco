using Finanzas.Forms;
using Finanzas.Forms_Endeudamiento;
using Finanzas.Forms_Liquidez;
using Finanzas.Forms_Rentabilidad;
using Finanzas.Poco;
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
        public DatosEstadoResultado datosEstadoResultado;
        public Main()
        {
            InitializeComponent();
            datosEstadoResultado = new DatosEstadoResultado();
            datosBalanceGeneral = new DatosBalanceGeneral();
        }

        private void balanceGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceGeneral Form = new BalanceGeneral();
            Form.MdiParent = this;
            Form.datosBalanceGeneral = datosBalanceGeneral;
            Form.Show();
        }

        private void capitalDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapitalTrabajo Form = new CapitalTrabajo();
            Form.MdiParent = this;
            Form.Show();
        }

        private void índiceDeSolvenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndiceSolvencia Form = new IndiceSolvencia();
            Form.MdiParent = this;
            Form.Show();
        }

        private void estadoDeResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadoResultado Form = new EstadoResultado();
            Form.MdiParent = this;
            Form.Info = datosEstadoResultado;
            Form.Show();
        }

        private void pruebaÁcidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaAcida Form = new PruebaAcida();
            Form.MdiParent = this;
            Form.Show();
        }

        private void rotaciónDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotacionInventario Form = new RotacionInventario();
            Form.MdiParent = this;
            Form.Show();
        }

        private void rotaciónDeCarteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotacionCartera Form = new RotacionCartera();
            Form.MdiParent = this;
            Form.Show();
        }

        private void rotaciónDeCuentasPorPagarACPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotacionCuentasxPagar Form = new RotacionCuentasxPagar();
            Form.MdiParent = this;
            Form.Show();
        }

        private void razónDeEndeudamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RazonEndeudamiento Form = new RazonEndeudamiento();
            Form.MdiParent = this;
            Form.Show();
        }

        private void razónPasivoCapitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RazonPasivoCapital Form = new RazonPasivoCapital();
            Form.MdiParent = this;
            Form.Show();
        }

        private void margenBrutoDeUtilidadMBUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MBU Form = new MBU();
            Form.MdiParent = this;
            Form.Show();
        }

        private void margenDeUtilidadesOperacionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UAI Form = new UAI();
            Form.MdiParent = this;
            Form.Show();
        }

        private void rotaciónDeActivoTotalALPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotacionActivoTotalLP Form = new RotacionActivoTotalLP();
            Form.MdiParent = this;
            Form.Show();
        }

        private void rendimientoDeInversiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ROA Form = new ROA();
            Form.MdiParent = this;
            Form.Show();
        }

        private void rendimientoDeCapitalComúnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RendimientoCapitalComun Form = new RendimientoCapitalComun();
            Form.MdiParent = this;
            Form.Show();
        }

        private void utilidadPorAcciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UtilidadAccion Form = new UtilidadAccion();
            Form.MdiParent = this;
            Form.Show();
        }

        private void dividendoPorAcciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DividendoAccion Form = new DividendoAccion();
            Form.MdiParent = this;
            Form.Show();
        }
    }
}