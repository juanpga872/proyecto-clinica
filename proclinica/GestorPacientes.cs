using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proclinica
{
    public static class GestorPacientes
    {
        public static List<Paciente> ListaPacientes { get; set; } = new List<Paciente>();

        public class Paciente
        {
            public string Nombre { get; set; }
            public string TipoDocumento { get; set; }
            public string Documento { get; set; }
            public string Genero { get; set; }
            public int Edad { get; set; }
            public string Telefono { get; set; }
        }
    }

}
