using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Obj2020;
using Xamarin.Forms;
using Acr.UserDialogs;
using System.Threading.Tasks;

namespace Obj2020
{
    public class Login : ContentPage
    {

        RelativeLayout VistaPrincipal;
        Label Titulo;
        Entry Documento;
        Entry Codigo;
        Entry Contraseña;
        Button botonIniciar, OlvidoClave;
        Image Logo;
        //Usuario My_User_Global;

        

        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);
           // My_User_Global = My_User;
            CrearVistas();
            AgregarVistas();
            AgregarEventos();
        }
        void CrearVistas()
        {
            VistaPrincipal = new RelativeLayout

            {
               
            };

            {
                BackgroundColor = Core.Principal;
            };

            Titulo = new Label

            {
                Text = "Bienvenidos",

                FontSize = 30,
                FontFamily = "Bold",
                BackgroundColor = Color.Transparent,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                TextColor = Core.Textos,
                // Margin = new Thickness(0, 0, 0,60)
            };

            Documento = new Entry
            {
                Placeholder = "No. Documento",
                FontSize = 12,
                TextColor = Core.Textos,
                HorizontalTextAlignment = TextAlignment.Start,
                

            };

            Codigo = new Entry
            {
                Placeholder = "Codigo estudiante",
                FontSize = 12,
                TextColor = Core.Textos,
                IsPassword = true,
                HorizontalTextAlignment = TextAlignment.Start

            };

            Contraseña = new Entry
            {
                Placeholder = "Contraseña",
                FontSize = 12,
                TextColor = Core.Textos,
                IsPassword = true,
                HorizontalTextAlignment = TextAlignment.Start

            };

            botonIniciar = new Button
            {
                Text = "Acceder a la App",
                BackgroundColor = Core.Botones,
                TextColor = Core.Textos,
                CornerRadius = 10
            };

            OlvidoClave = new Button
            {
                Text = "Olvidaste tu  Contraseña ? ",
                FontSize = 10,
                BackgroundColor = Color.Transparent,
                TextColor = Core.Navegacion,
                CornerRadius = 10
            };

            Logo = new Image

            {
                Source = Core.Logo
            };




        }
        void AgregarVistas()

        {

            VistaPrincipal.Children.Add(Logo,

                      Constraint.RelativeToParent((p) => { return 50; }),
                      Constraint.RelativeToParent((p) => { return 70; }),
                      Constraint.RelativeToParent((p) => { return p.Width * 0.706; }),
                      Constraint.RelativeToParent((p) => { return p.Height * 0.146; }));


            VistaPrincipal.Children.Add(Titulo,

                   Constraint.RelativeToParent((p) => { return 40; }),
                   Constraint.RelativeToParent((p) => { return 180; }),
                   Constraint.RelativeToParent((p) => { return p.Width * 0.8; }),
                   Constraint.RelativeToParent((p) => { return p.Height * 0.074; }));

            VistaPrincipal.Children.Add(Documento,

                   Constraint.RelativeToParent((p) => { return 50; }),
                   Constraint.RelativeToParent((p) => { return 280; }),
                   Constraint.RelativeToParent((p) =>
                   {
                       return p.Width * 0.75;
                   }), Constraint.RelativeToParent((p) => { return p.Height * 0.0773; }));

            VistaPrincipal.Children.Add(Codigo,

                 Constraint.RelativeToParent((p) => { return 50; }),
                 Constraint.RelativeToParent((p) => { return 330; }),
                 Constraint.RelativeToParent((p) =>
                 {
                     return p.Width * 0.75;
                 }), Constraint.RelativeToParent((p) => { return p.Height * 0.0773; }));

            VistaPrincipal.Children.Add(Contraseña,

                  Constraint.RelativeToParent((p) => { return 50; }),
                  Constraint.RelativeToParent((p) => { return 380; }),
                  Constraint.RelativeToParent((p) =>
                  {
                      return p.Width * 0.75;
                  }), Constraint.RelativeToParent((p) => { return p.Height * 0.0773; }));

            VistaPrincipal.Children.Add(botonIniciar,

                  Constraint.RelativeToParent((p) => { return 50; }),
                  Constraint.RelativeToParent((p) => { return 510; }),
                  Constraint.RelativeToParent((p) =>
                  {
                      return p.Width * 0.75;
                  }), Constraint.RelativeToParent((p) => { return p.Height * 0.0773; }));


            VistaPrincipal.Children.Add(OlvidoClave,

                 Constraint.RelativeToParent((p) => { return 50; }),
                 Constraint.RelativeToParent((p) => { return 560; }),
                 Constraint.RelativeToParent((p) =>
                 {
                     return p.Width * 0.75;
                 }), Constraint.RelativeToParent((p) => { return p.Height * 0.0773; }));


           

            Content = VistaPrincipal;

        }

        void AgregarEventos()

        

        {
            botonIniciar.Clicked += BotonIniciar_Clicked;
            OlvidoClave.Clicked += OlvidoClave_Clicked;

        }


        private async void OlvidoClave_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Notificacion", "Desea Recuperar su Contraseña", "Si");
            await Navigation.PushAsync(new Recuperar_Contraseña());
        }

      
        private async void BotonIniciar_Clicked(object sender, EventArgs EventoBotonIniciar)
        {
            if (String.IsNullOrWhiteSpace(Documento.Text))
            {
                await DisplayAlert("Advertencia", "Favor Digite su Numero de Identificacion, es obligatorio.", "Aceptar");
                return;

                
            }

           
         

            if (String.IsNullOrWhiteSpace(Codigo.Text))
            {
                await DisplayAlert("Advertencia", "Favor Digite su Codigo de Estudiate", "Aceptar");
                return;
            }
            if (String.IsNullOrWhiteSpace(Contraseña.Text))
            {
                await DisplayAlert("Advertencia", "Favor Digite la Contraseña.", "Aceptar");
                return;
            }

         

            int i = Contraseña.Text.Length;
            if (i <= 8)
            {
                Contraseña.TextColor = Color.Red;
                await DisplayAlert("Notificacion", "Digite una Contraseña con Mas de 8 Valores", "Aceptar");

                return;
            }

            else
           


            {
                await DisplayAlert("Notificacion", "Datos Ingresados Correctamente", "Aceptar");

                bool cancelada = false;

                using (var dialog = UserDialogs.Instance.Progress("Cargando...", () => cancelada = true, "Cancelar"))

                {

                    for (i = 1; i <= 10; i++)
                    {
                        await Task.Delay(1000);
                        if (!cancelada)
                        {
                            dialog.PercentComplete = i * 10;
                        }
                    }
                }





              //  await Navigation.PushAsync(new PaginaPrincipal(My_User_Global));

                await Navigation.PushAsync(new MasterPage());
                Navigation.RemovePage(this);
            }

        }
    }
}
