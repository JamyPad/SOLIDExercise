using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSolid
{
    public  class Empleados:ISalario
    {
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string Turno { get; set; }    
        public float PagoHora { get; set; }    

  
        public Empleados(string nombre, string apellido,string turno)
        {
            NombreEmpleado = nombre;
            ApellidoEmpleado = apellido;
            Turno = turno;
        }      
        public virtual float obtenerSalario(float TotalHoras)
        {
            return TotalHoras*PagoHora;
        }

    }

}
