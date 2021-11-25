using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSolid
{
    public class Actividad
    {
        public string Nombre { get; set; }
        public float Horas { get; set; }        
        public ISalario Empleado;

        public Actividad(string nombre)
        {
            Nombre = nombre;            
        }
        public void AgregarEmpleado(ISalario empleado,float horas)
        {
            Empleado = empleado;
            Horas = horas;
        }
        public float CalcularCosto()
        {
            return Empleado.obtenerSalario(Horas);
        }


    }
}
