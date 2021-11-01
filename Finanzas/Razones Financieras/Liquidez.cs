using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Razones_Financieras
{
    public class Liquidez
    {
        public double CapitalTrabajo(double ActivoC, double PasivoC)
        {
            return ActivoC - PasivoC;
        }

        public double IndiceSolvencia(double ActivoC, double PasivoC)
        {
            return ActivoC / PasivoC;
        }

        public double PruebaAcida(double ActivosC, double Inventario, double PasivosC)
        {
            return (ActivosC - Inventario) / PasivosC;
        }

        public double RotacionInventario(double CostoMercanciaVendida, double PromedioInv)
        {
            return CostoMercanciaVendida / PromedioInv;
        }

        public double RotacionCartera(double VentasCredito, double PromCuentaxCobrar)
        {
            return VentasCredito / PromCuentaxCobrar;
        }

        public double RotacionCuentasxPagarCortoPlazo(double ComprasCredito, double PromCuentasxPagar)
        {
            return ComprasCredito / PromCuentasxPagar;
        }

        public double TextBox(System.Windows.Forms.TextBox T)
        {
            return Double.Parse(T.Text);
        }
    }
}
