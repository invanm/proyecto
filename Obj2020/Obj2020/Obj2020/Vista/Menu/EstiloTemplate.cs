using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Obj2020
{
   public class EstiloTemplate : ViewCell
    {
        public EstiloTemplate()
        {
            StackLayout Celdapadre = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Padding = 10
            };
            StackLayout Contenedor = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Image image = new Image
            {
                WidthRequest = 40,
                HeightRequest = 40 
            };

            Label label = new Label
            {
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Core.Textos
            };

            image.SetBinding(Image.SourceProperty, "Icono");
            image.SetBinding(Image.IsVisibleProperty, "IconoVisible");
            label.SetBinding(Label.TextProperty, "Titulo");

            Contenedor.Children.Add(image);
            Contenedor.Children.Add(label);
            Celdapadre.Children.Add(Contenedor);
            View = Celdapadre;


        }

    }
}
