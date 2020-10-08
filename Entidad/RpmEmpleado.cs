using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    class RpmEmpleado
    {
        public Persona Persona { get; set; }
        public decimal PorcentajeIngresoCotizacion { get; set; }
        public decimal Liquidacion { get; set; }
        public decimal S { get; set; }
        public decimal SMV { get; set; }
        public decimal SemanaExtra { get; set; }
        public decimal Incremento { get; set; }

        public RpmEmpleado()
        {
           
        }

        public RpmEmpleado(Persona persona)
        {
            Persona = persona;
            SMV = 980657;
            CalcularS();

           
        }

        public void CalcularS()
        {
            S = Persona.IBL / SMV;
        }


        public void CalculoIngresoCotizacion()
        {
            if(Persona.TotalSemanaCotizada == 1300)
            {
                PorcentajeIngresoCotizacion = Convert.ToDecimal(Convert.ToDecimal(65.5) - (3 / 2 * S));
            }
            else if(Persona.TotalSemanaCotizada > 1300)
            {
                SemanaExtra = Persona.TotalSemanaCotizada - 1300;

                Incremento = Math.Floor(SemanaExtra / 50) * Convert.ToDecimal(1.5);
                if(Incremento > 80)Incremento = 80;              
                PorcentajeIngresoCotizacion = Convert.ToDecimal(65.5 - 0.5) * S + Incremento;
            }
    
        }

        public void CalcularLiquidacion()
        {
            CalculoIngresoCotizacion();
            Liquidacion = PorcentajeIngresoCotizacion * Persona.IBL;
        }


    }
}
