using Finanzas.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas.Forms
{
    public partial class EstadoResultado : Form
    {
        public DatosEstadoResultado Info { get; set; }
        string[] Row = {"Ventas", "Costo de Ventas", "Margen Bruto", "Gastos Operativos", "Gastos de Ventas", "Renta de Almacen", "Sueldos de Agentes",
        "Servicios Básicos", "Gastos de Administración", "Renta de Oficinas", "Sueldo del Personal de Oficinas", "Papelería y Útiles de Oficina", 
        "Gastos Financieros", "Impuestos Pagados", "Utilidad de Operación", "IR", "Utilidad Neta", "Pago de Impuesto", "Utilidad Retenida"};

        public EstadoResultado()
        {
            InitializeComponent();
        }

        private void EstadoResultado_Load(object sender, EventArgs e)
        {
            DgvEstadoResultado.Columns.Add("", "Cuenta");
            DgvEstadoResultado.Columns.Add("", "A");
            DgvEstadoResultado.Columns.Add("", "B");
            DgvEstadoResultado.Columns.Add("", "C");

            for (int i = 0; i < Row.Length; i++)
            {
                DgvEstadoResultado.Rows.Add(Row[i]);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacion(out double Ventas, out double CostoVentas, out double PagosImpuestos, out double RentaAlmacen, out double SueldosAgentes, out double ServiciosBasicos, out double RentaOficinas, out double SueldoPersonalOficinas, out double PapeleriaUtilesOficinas, out double InteresesPagados);
                double MargenBruto = Ventas - CostoVentas;
                double GastosVentas = RentaAlmacen + SueldosAgentes + ServiciosBasicos;
                double GastosAdministracion = RentaOficinas + SueldoPersonalOficinas + PapeleriaUtilesOficinas;
                double GastosFinancieros = InteresesPagados;
                double GastosOperativos = GastosVentas + GastosAdministracion + GastosFinancieros;
                double UtilidadOperacion = MargenBruto - GastosOperativos;
                double Impuestos_IR = Math.Abs(UtilidadOperacion * 0.30);
                double UtilidadNeta = UtilidadOperacion - Impuestos_IR;
                double UtilidadesRetenidas = UtilidadNeta - PagosImpuestos;

                Info = new DatosEstadoResultado()
                { 
                    Ventas = Ventas,
                    CostoVentas = CostoVentas,
                    UtilidadNeta = UtilidadNeta,
                    IR = Impuestos_IR,
                    GastosFinancieros = GastosFinancieros,
                    UtilidadOperacion = UtilidadOperacion,
                    GastosOperativos = GastosOperativos,
                    MargenBruto = MargenBruto,
                    GastosAdministracion = GastosAdministracion,
                    GastosVentas = GastosVentas,
                    InteresesPagados = InteresesPagados,
                    PagoImpuesto = PagosImpuestos,
                    PapeleriaUtilesOficina = PapeleriaUtilesOficinas,
                    RentaAlmacen = RentaAlmacen,
                    RentaOficinas = RentaOficinas,
                    ServiciosBasicos = ServiciosBasicos,
                    SueldoAgentes = SueldosAgentes,
                    SueldoPersonalOficinas = SueldoPersonalOficinas,
                    UtilidadRetenida = UtilidadesRetenidas,
                };

                MessageBox.Show("Se ha guardado con éxito!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Se ha producido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Validacion(out double Ventas, out double CostoVentas, out double PagosImpuestos, out double RentaAlmacen, out double SueldosAgentes, out double ServiciosBasicos, out double RentaOficinas, out double SueldoPersonalOficinas, out double PapeleriaUtilesOficinas, out double InteresesPagados)
        {
            if (!Double.TryParse(TxtVentas.Text, out double V) || String.IsNullOrEmpty(TxtVentas.Text))
            {
                throw new ArgumentException("El valor de las Ventas no es válido");
            }
            Ventas = V;
            if (!Double.TryParse(TxtCostoVentas.Text, out double CV) || String.IsNullOrEmpty(TxtCostoVentas.Text))
            {
                throw new ArgumentException("El valor del Costo de Ventas no es válido");
            }
            CostoVentas = CV;
            if (!Double.TryParse(TxtPagosImpuestos.Text, out double PG) || String.IsNullOrEmpty(TxtPagosImpuestos.Text))
            {
                throw new ArgumentException("El valor del Pago de Impuestos no es válido");
            }
            PagosImpuestos = PG;
            if (!Double.TryParse(TxtRentaAlmacen.Text, out double RA) || String.IsNullOrEmpty(TxtRentaAlmacen.Text))
            {
                throw new ArgumentException("El valor de la Renta del Almacen no es válido");
            }
            RentaAlmacen = RA;
            if (!Double.TryParse(TxtSueldosAgentes.Text, out double SA) || String.IsNullOrEmpty(TxtSueldosAgentes.Text))
            {
                throw new ArgumentException("El valor del Sueldo de Agentes no es válido");
            }
            SueldosAgentes = SA;
            if (!Double.TryParse(TxtServiciosBasicos.Text, out double SB) || String.IsNullOrEmpty(TxtServiciosBasicos.Text))
            {
                throw new ArgumentException("El valor de Servicios Básicos no es válido");
            }
            ServiciosBasicos = SB;
            if (!Double.TryParse(TxtRentaOficinas.Text, out double RO) || String.IsNullOrEmpty(TxtRentaOficinas.Text))
            {
                throw new ArgumentException("El valor de la Renta de Oficinas no es válido");
            }
            RentaOficinas = RO;
            if (!Double.TryParse(TxtSueldoPersonalOficinas.Text, out double SPO) || String.IsNullOrEmpty(TxtSueldoPersonalOficinas.Text))
            {
                throw new ArgumentException("El valor del Sueldo Personal de Oficinas no es válido");
            }
            SueldoPersonalOficinas = SPO;
            if (!Double.TryParse(TxtPapeleriaUtilesOficina.Text, out double PUO) || String.IsNullOrEmpty(TxtPapeleriaUtilesOficina.Text))
            {
                throw new ArgumentException("El valor de Papelería y Útiles de Oficina no es válido");
            }
            PapeleriaUtilesOficinas = PUO;
            if (!Double.TryParse(TxtInteresesPagados.Text, out double IP) || String.IsNullOrEmpty(TxtInteresesPagados.Text))
            {
                throw new ArgumentException("El valor de los Intereses Pagados no es válido");
            }
            InteresesPagados = IP;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (Info.Ventas == 0)
            {
                MessageBox.Show("Debe de guardar los datos antes de mostrar el Estado de Resultado", "Se ha producido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DgvEstadoResultado.Rows[0].Cells[1].Value = Info.Ventas.ToString();
                DgvEstadoResultado.Rows[1].Cells[1].Value = Info.CostoVentas.ToString();
                DgvEstadoResultado.Rows[2].Cells[3].Value = Info.MargenBruto.ToString();
                DgvEstadoResultado.Rows[5].Cells[1].Value = Info.RentaAlmacen.ToString();
                DgvEstadoResultado.Rows[6].Cells[1].Value = Info.SueldoAgentes.ToString();
                DgvEstadoResultado.Rows[7].Cells[1].Value = Info.ServiciosBasicos.ToString();
                DgvEstadoResultado.Rows[7].Cells[2].Value = Info.GastosVentas.ToString();
                DgvEstadoResultado.Rows[9].Cells[1].Value = Info.RentaOficinas.ToString();
                DgvEstadoResultado.Rows[10].Cells[1].Value = Info.SueldoPersonalOficinas.ToString();
                DgvEstadoResultado.Rows[11].Cells[1].Value = Info.PapeleriaUtilesOficina.ToString();
                DgvEstadoResultado.Rows[11].Cells[2].Value = Info.GastosAdministracion.ToString();
                DgvEstadoResultado.Rows[13].Cells[1].Value = Info.InteresesPagados.ToString();
                DgvEstadoResultado.Rows[13].Cells[2].Value = Info.GastosFinancieros.ToString();
                DgvEstadoResultado.Rows[14].Cells[3].Value = Info.UtilidadOperacion.ToString();
                DgvEstadoResultado.Rows[15].Cells[1].Value = Info.IR.ToString();
                DgvEstadoResultado.Rows[16].Cells[3].Value = Info.UtilidadNeta.ToString();
                DgvEstadoResultado.Rows[17].Cells[1].Value = Info.PagoImpuesto.ToString();
                DgvEstadoResultado.Rows[18].Cells[3].Value = Info.UtilidadRetenida.ToString();
            }
        }
    }
}
