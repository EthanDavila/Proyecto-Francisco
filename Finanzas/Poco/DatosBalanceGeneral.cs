using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.POCO
{
    public class DatosBalanceGeneral
    {
        public double Activos_Corrientes { get; set; }
        public double Caja { get; set; }
        public double Banco { get; set; }
        public double Cliente { get; set; }
        public double Inventario { get; set; }
        public double DeudoresDiversos { get; set; }
        public double Activos_NoCorrientes { get; set; }
        public double Maquinaria { get; set; }
        public double Transporte { get; set; }
        public double Terreno { get; set; }
        public double Edificio { get; set; }
        public double Otros_Activos { get; set; }
        public double InversionProceso { get; set; }
        public double FondoAmortizacion { get; set; }
        public double Total_Activos { get; set; }
        public double Pasivos_Corrientes { get; set; }
        public double Proveedor { get; set; }
        public double AcreedorDiverso { get; set; }
        public double IVAxPagar { get; set; }
        public double InteresxPagar { get; set; }
        public double Pasivos_NoCorrientes { get; set; }
        public double AcreedorHipotecario { get; set; }
        public double BonoxPagar { get; set; }
        public double AcreedorBancario { get; set; }
        public double DocumentoxPagar { get; set; }
        public double Patrimonio { get; set; }
        public double CapitalSocial { get; set; }
        public double UtilidadesRetenidas { get; set; }
        public double Donacion { get; set; }
        public double PerdidaAcumulada { get; set; }
        public double Total_Pasivos { get; set; }
    }
}