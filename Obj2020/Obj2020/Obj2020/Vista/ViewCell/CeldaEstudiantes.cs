using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Obj2020
{
    public class CeldaEstudiantes : ViewCell
 
    {
        StackLayout Vista_General_Celda, VistaLabels;
        Label LabelNombreEstudiante, LabelMateria, LabelDocente, LabelNota;
        public CeldaEstudiantes()
        {
            Vista_General_Celda = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Margin = new Thickness(12, 0, 12, 0)
            };
            VistaLabels = new StackLayout
            {
                HorizontalOptions = LayoutOptions.StartAndExpand
            };
            LabelNombreEstudiante = new Label
            {

            };
            LabelMateria = new Label
            {

            };
            LabelDocente = new Label
            {

            };
            LabelNota = new Label
            {
                FontSize = 30,
                TextColor = Core.Navegacion,
                VerticalOptions = LayoutOptions.Center,
              

            };

            LabelNombreEstudiante.SetBinding(Label.TextProperty, "Nombre_Completo");
            LabelMateria.SetBinding(Label.TextProperty, "Materia");
            LabelDocente.SetBinding(Label.TextProperty, "Docente");
            LabelNota.SetBinding(Label.TextProperty, "Nota");

            VistaLabels.Children.Add(LabelNombreEstudiante);
            VistaLabels.Children.Add(LabelMateria);
            VistaLabels.Children.Add(LabelDocente);

            Vista_General_Celda.Children.Add(VistaLabels);
            Vista_General_Celda.Children.Add(LabelNota);

            View = Vista_General_Celda;

        }
    };
}
    
