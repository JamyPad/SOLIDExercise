using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSolid
{
    public interface ISalario
    {
        string NombreEmpleado { get; set; }
        string ApellidoEmpleado { get; set; }
        string Turno { get; set; }
        float PagoHora { get; set; }

        float obtenerSalario(float TotalHoras);
    }
}
