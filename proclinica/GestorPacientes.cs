using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proclinica
{
    public static class GestorPacientes
    {
        public static List<Paciente> ListaPacientes { get; set; } = new List<Paciente>
        {
            new Paciente
            {
                Nombre = "María Rodríguez",
                TipoDocumento = "Cédula de Ciudadanía",
                Documento = "1056789012",
                Genero = "Femenino",
                Edad = 29,
                Telefono = "3124567890"
            },
            new Paciente
            {
                Nombre = "Andrés Gómez",
                TipoDocumento = "Cédula de Ciudadanía",
                Documento = "1045678901",
                Genero = "Masculino",
                Edad = 35,
                Telefono = "3102345678"
            },
            new Paciente
            {
                Nombre = "Camila Torres",
                TipoDocumento = "Tarjeta de Identidad",
                Documento = "1122334455",
                Genero = "Femenino",
                Edad = 17,
                Telefono = "3119876543"
            },
            new Paciente
            {
                Nombre = "Luis Pérez",
                TipoDocumento = "Cédula de Extranjería",
                Documento = "2003344556",
                Genero = "Masculino",
                Edad = 42,
                Telefono = "3001234567"
            }
        };
        public class Paciente
        {
            public string Nombre { get; set; }
            public string TipoDocumento { get; set; }
            public string Documento { get; set; }
            public string Genero { get; set; }
            public int Edad { get; set; }
            public string Telefono { get; set; }

            public List<Cita> HistorialCitas { get; set; } = new List<Cita>();
        }
    }

}
