using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Subsidiado : LiquidacionRegimen
    {

        public override double CalcularCuotaModeradora(double tarifa, double Valorservicio)
        {
            double CuotaModeradora = Valorservicio * tarifa;
            return CuotaModeradora;
        }

        public override double CalcularTarifa(double salario)
        {
            return 0.05;
        }

        public override double CalcularTopeMaximo(double salario)
        {
            return 200000;
        }

        public override double CalcularExecederTopeMaximo(double cuotaModeradora)
        {
            if (cuotaModeradora>200000)
            {
                return 200000;
            }
            else
            {
                return cuotaModeradora;
            }

        }



    }
}
