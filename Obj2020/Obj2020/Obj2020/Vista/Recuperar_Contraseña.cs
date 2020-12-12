using Obj2020;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Obj2020
{
    public class Recuperar_Contraseña : ContentPage


    {
        RelativeLayout VistaRecuperarClave;

        Entry RecuperarUsuario;
        Button RecuperarClave;
        BoxView BarraNavegacion2;
        Label Titulo_RecuperarClave;
        Image Icono_atras;
        TapGestureRecognizer TapImagen2;

        public Recuperar_Contraseña()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            CrearVistas();
            AgregarVistas();
            AgregarEventos();
        }
        void CrearVistas()
        {
            VistaRecuperarClave = new RelativeLayout

            {
                
            };

            {
                BackgroundColor = Color.White;
            };
            BarraNavegacion2 = new BoxView
            {
                BackgroundColor = Core.Principal
            };
            Icono_atras = new Image

            {
                Source = Core.Icono_atras
                
            };
            TapImagen2 = new TapGestureRecognizer
            {

            };

            Titulo_RecuperarClave = new Label
            {
                Text = "Recuperar Contraseña",
                FontSize = 22,
                TextColor = Core.Textos,
                HorizontalTextAlignment = TextAlignment.Center
            };
            RecuperarUsuario = new Entry
            {
                Placeholder = "Correo Institucional",
                FontSize = 15,
                TextColor = Core.Textos,
                HorizontalTextAlignment = TextAlignment.Start,

            };

            RecuperarClave = new Button
            {
                Text = "Recuperar",
                BackgroundColor = Core.Botones,
                TextColor = Core.Textos,
                BorderColor = Core.Principal,
                BorderWidth = 2,
                CornerRadius = 10

            };

        }
        void AgregarVistas()


        {

            VistaRecuperarClave.Children.Add(BarraNavegacion2,

                       Constraint.RelativeToParent((p) => { return 0; }),
                       Constraint.RelativeToParent((p) => { return 0; }),
                       Constraint.RelativeToParent((p) => { return p.Width; }),
                       Constraint.RelativeToParent((p) => { return p.Height * 0.083; }));

            VistaRecuperarClave.Children.Add(Titulo_RecuperarClave,

                      Constraint.RelativeToParent((p) => { return 0; }),
                      Constraint.RelativeToParent((p) => { return p.Height * 0.022; }),
                      Constraint.RelativeToParent((p) => { return p.Width; }));

            VistaRecuperarClave.Children.Add(Icono_atras,

                     Constraint.RelativeToParent((p) => { return p.Width * 0; }),
                     Constraint.RelativeToParent((p) => { return 0; }),
                     Constraint.RelativeToParent((p) => { return p.Width * 0.149; }),
                     Constraint.RelativeToParent((p) => { return p.Height * 0.083; }));


            VistaRecuperarClave.Children.Add(RecuperarUsuario,

                      Constraint.RelativeToParent((p) => { return 50; }),
                      Constraint.RelativeToParent((p) => { return 270; }),
                      Constraint.RelativeToParent((p) => { return p.Width * 0.75; }),
                      Constraint.RelativeToParent((p) => { return p.Height * 0.0773; }));


            VistaRecuperarClave.Children.Add(RecuperarClave,

                  Constraint.RelativeToParent((p) => { return 50; }),
                  Constraint.RelativeToParent((p) => { return 370; }),
                  Constraint.RelativeToParent((p) => { return p.Width * 0.75; }),
                  Constraint.RelativeToParent((p) => { return p.Height * 0.0773; }));

            Content = VistaRecuperarClave;
        }
        void AgregarEventos()

       
        {
            RecuperarClave.Clicked += RecuperarClave_Clicked;
            Icono_atras.GestureRecognizers.Add(TapImagen2);
            TapImagen2.Tapped += TapImagen2_Tapped;
            }
         
        private async void TapImagen2_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

       
        private async void RecuperarClave_Clicked(object sender, EventArgs e)
        {


            if (String.IsNullOrWhiteSpace(RecuperarUsuario.Text))
            {
                await this.DisplayAlert("Advertencia", "Debe Digitar Correo Electronico Para Lograr Reestablecer Acceso", "Aceptar");
                return;
            }

        
            else
            {
             bool isEmail = Regex.IsMatch(RecuperarUsuario.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (!isEmail)
                {
                    await this.DisplayAlert("Advertencia", "Favor Digite Un Correo Valido", "Aceptar");
                    return ;
                }
            }

            
            {
                await DisplayAlert("Notificacion", "Contraseña Reestablecida", "Aceptar");
                await Navigation.PopAsync();
            }
    }
    }
}

