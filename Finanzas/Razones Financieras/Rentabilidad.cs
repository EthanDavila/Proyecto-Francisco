using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Razones_Financieras
{
    public class Rentabilidad
    {
        public double MargenBrutoUtilidad(double Ventas, double CostoVentas)
        {
            return (Ventas - CostoVentas) / Ventas;
        }

        public double MargenUtilidadesOperacionales(double UtilidadOperacional, double Ventas)
        {
            return UtilidadOperacional / Ventas;
        }

        public double RotacionActivoTotalLP(double Ventas, double ActivoTotal)
        {
            return Ventas / ActivoTotal;
        }

        public double RendimientoInversion(double UDI, double ActivoTotal)
        {
            return UDI / ActivoTotal;
        }

        public double RendimientoCapitalComun(double UDI, double DividendosPreferentes, double CapitalContable, double CapitalPreferente)
        {
            return (UDI - DividendosPreferentes) / (CapitalContable - CapitalPreferente);
        }

        public double UtilidadAccion(double UtildadAccionesOrdinarias, double NoAccionesOrdinarias)
        {
            return UtildadAccionesOrdinarias / NoAccionesOrdinarias;
        }

        public double DividendoAccion(double DividendosPagados, double NoAccionesPagadasVigentes)
        {
            return DividendosPagados / NoAccionesPagadasVigentes;
        }
    }
}
