using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mant
{
    public class Cls_Dimension_DAL
    {
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public int Tipo { get; set; }
        public int Estilo { get; set; }
        public int Dimension { get; set; }
        public int IdUsuario { get; set; }
    }
}
