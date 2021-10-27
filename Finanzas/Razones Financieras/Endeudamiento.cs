using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Razones_Financieras
{
    public class Endeudamiento
    {
        public double RazonEndeudamiento(double PasivoTotal, double ActivoTotal)
        {
            return (PasivoTotal / ActivoTotal) * 100;
        }

        public double RazonPasivoCapital(double PasivoLP, double Capital)
        {
            return PasivoLP / Capital;
        }
    }
}
