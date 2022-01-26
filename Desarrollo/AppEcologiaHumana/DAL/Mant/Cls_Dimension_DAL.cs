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

    public class Cls_ResultadoDimension_DAL
    {
        public int IdResultado { get; set; }
        public int TotalResultado { get; set; }
        public int Dimension { get; set; }
        public int IdUsuario { get; set; }
    }
}
