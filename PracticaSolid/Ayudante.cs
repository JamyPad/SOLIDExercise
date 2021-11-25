using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSolid
{
    class Ayudante:Empleados, IHorasExtras
    {
        public Ayudante(string nombre,string apellido,string turno):base(nombre,apellido,turno)
        {
            PagoHora = 60;   
        }
        public override float obtenerSalario(float TotalHoras)           
        {            
            if(Turno=="Nocturno")
            {
                return PracticaSolid.SalarioTurnos.CalcularSalarioNocturno(CalcularSalario(PagoHora));
            }
            else
            {
                return CalcularSalario(PagoHora);
            }            
        }
        public  float obtenerHorasExtras(float Horas)
        {
            return Horas*80;
        }
   
        public float CalcularSalario(float horas)
        {
            return base.obtenerSalario(horas); // El ayudante gana 60 lps la hora
        }
    }
}
