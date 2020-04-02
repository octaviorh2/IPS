using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contributivo : LiquidacionRegimen
    {
        const double SALARIOMINIMO = 877803;
        
        public override double CalcularCuotaModeradora(double tarifa, double Valorservicio)
        {
            double CuotaModeradora = Valorservicio * tarifa;
            return CuotaModeradora;
        }

        public override double CalcularTarifa(double salario)
        {
            int CantidadSalario = CalcularCantidadSalario(salario);

            if (CantidadSalario < 2)
            {
                return 0.15;
            }
            else if (CantidadSalario >= 2 || CantidadSalario <= 5)
            {
                return 0.2;
            }
            else
            {
                return 0.25;
            }  
        }

        public override double CalcularTopeMaximo(double salario)
        {
            int CantidadSalario = CalcularCantidadSalario(salario);

            if (CantidadSalario < 2)
            {
                return 250000;
            }
            else if (CantidadSalario >= 2 || CantidadSalario <= 5)
            {
                return 900000;
            }
            else
            {
                return 1500000;
            }
        }

        public int CalcularCantidadSalario(Double salario)
        {
            int CantidadSalario = Convert.ToInt32(salario / SALARIOMINIMO);

            return CantidadSalario;
        }

        public override double CalcularExecederTopeMaximo(double cuotaModeradora)
        {
            if (cuotaModeradora > 250000)
            {
                return  250000;
            }
            else if (cuotaModeradora > 900000)
            {
                return 900000;
            }
            else if (cuotaModeradora > 1500000)
            {
                return 1500000;
            }
            else
            {
                return cuotaModeradora;
            }
        }
    
    }
}
