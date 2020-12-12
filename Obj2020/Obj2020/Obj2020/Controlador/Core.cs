using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace Obj2020
{
    public static class Core
    {
        // sesion colores 
    public static Color Navegacion { get; } = Color.FromHex("#17A8E5");
    public static Color Botones { get; } = Color.FromHex("#78B568");
    public static Color Textos { get; } = Color.FromHex("#546467");
    public static Color Principal { get; } = Color.FromHex("#97946B");
    

        // seccion iconos 

        public static ImageSource Icono_salir { get; } = ImageSource.FromFile("Icono_salir.png");
        public static ImageSource Icono_atras { get; } = ImageSource.FromFile("Icono_atras.png");
        public static ImageSource Logo { get; } = ImageSource.FromFile("Logo.png");
        
       









    }
}
