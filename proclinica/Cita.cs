using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proclinica
{
    public class Cita
    {
        public string Paciente { get; set; }
        public string Doctor { get; set; }
        public string Consultorio { get; set; }
        public DateTime FechaHora { get; set; }
        public string Motivo { get; set; }
    }
}
