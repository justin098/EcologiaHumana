using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class Cls_Login_DAL
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdSede { get; set; }
        public int IdRol { get; set; }
        public int IdProfesion { get; set; }

    }
}
