using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionRegimen
    {
        public string NumeroLiquidacion{ get; set; }
        public string IdentificacionPaciente { get; set; }
        public String TipoAfiliacion { get; set; }
        public  double SalarioPaciente { get; set; }
        public double ValorServicio { get; set; }
        public double ValorTarifa { get; set; }
        public double ValorLiquidacion { get; set; }
        public double TopeMaximo { get; set; }
        public double ValorCuotaModeradora { get; set; }

        public abstract double CalcularCuotaModeradora(double tarifa,double Valorservicio);
        public abstract double CalcularTarifa(double salario);
        public abstract double CalcularTopeMaximo(double salario);
        public abstract double CalcularExecederTopeMaximo(double cuotaModeradora);


    }
}
