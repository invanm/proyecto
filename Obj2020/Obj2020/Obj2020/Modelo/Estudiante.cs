using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace Obj2020
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Materia { get; set; }
        public string Docente { get; set; }
        public string Nota { get; set; }
        public string Nombre_Completo { get { return Nombre + " " + Apellido; } }

        public double Not1 { get; set; }

        public double Not2 { get; set; }

        public double Not3 { get; set; }

        public double Nota_Completa { get { return ((Not1 * 0.030) + (Not2 * 0.030) + (Not3 * 0.060)); } }
    }
}
