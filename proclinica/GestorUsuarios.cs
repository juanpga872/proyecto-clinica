using System;
using System.Collections.Generic;
using static proclinica.GestorUsuarios;

namespace proclinica
{
    internal static class GestorUsuarios
    {
        public class usuario
        {
            public string Usuario { get; set; }  
            public string Contraseña { get; set; }
            public string Rol { get; set; }
            public string Documento { get; set; }
        }

        public static List<usuario> ListaUsuarios = new List<usuario>
        {
            new usuario { Usuario = "admin", Contraseña = "1234", Rol = "Administrador",Documento="123" },
            new usuario { Usuario = "recep", Contraseña = "1234", Rol = "Recepcionista",Documento="1234" },
            new usuario { Usuario = "doc", Contraseña = "1234", Rol = "Doctor",Documento="12345" }
        };
        public static usuario UsuarioActual { get; set; }
    }
}
