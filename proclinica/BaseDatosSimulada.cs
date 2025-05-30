using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proclinica
{
    class BaseDatosSimulada
    {
        public static List<Doctor> ListaDoctores = new List<Doctor>
        {
            new Doctor
            {
                NombreCompleto = "Dra. Laura Martínez",
                Genero = "Femenino",
                Especialidad = "Pediatría",
                Documento = "1000123456",
                TipoDocumento = "Cédula de Ciudadanía",
                Edad = 38,
                Telefono = "3101234567"
            },
            new Doctor
            {
                NombreCompleto = "Dr. Carlos Gómez",
                Genero = "Masculino",
                Especialidad = "Medicina General",
                Documento = "1000234567",
                TipoDocumento = "Cédula de Ciudadanía",
                Edad = 45,
                Telefono = "3009876543"
            },
            new Doctor
            {
                NombreCompleto = "Dra. Ana Torres",
                Genero = "Femenino",
                Especialidad = "Ginecología",
                Documento = "1000345678",
                TipoDocumento = "Cédula de Ciudadanía",
                Edad = 40,
                Telefono = "3112345678"
            },
            new Doctor
            {
                NombreCompleto = "Dr. Juan Pérez",
                Genero = "Masculino",
                Especialidad = "Cardiología",
                Documento = "1000456789",
                TipoDocumento = "Cédula de Ciudadanía",
                Edad = 50,
                Telefono = "3123456789"
            }
        };
    }
}
