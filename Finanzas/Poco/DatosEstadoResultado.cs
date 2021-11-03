using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Poco
{
    public class DatosEstadoResultado
    {
        public double Ventas { get; set; }
        public double CostoVentas { get; set; }
        public double MargenBruto { get; set; }
        public double GastosOperativos { get; set; }
        public double GastosVentas { get; set; }
        public double RentaAlmacen { get; set; }
        public double SueldoAgentes { get; set; }
        public double ServiciosBasicos { get; set; }
        public double GastosAdministracion { get; set; }
        public double RentaOficinas { get; set; }
        public double SueldoPersonalOficinas { get; set; }
        public double PapeleriaUtilesOficina { get; set; }
        public double UtilidadOperacion { get; set; }
        public double GastosFinancieros { get; set; }
        public double InteresesPagados { get; set; }
        public double UtilidadImpuestos { get; set; }
        public double IR { get; set; }
        public double UtilidadNeta { get; set; }
        public double PagoImpuesto { get; set; }
        public double UtilidadRetenida { get; set; }
    }
}
