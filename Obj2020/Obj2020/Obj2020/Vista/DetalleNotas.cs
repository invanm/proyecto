using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;


namespace Obj2020
{
    public class DetalleNotas : ContentPage
    {

        RelativeLayout Vista_PrincipalNotas;
        BoxView BarraNavegacion, Nota1, Nota2, Nota3;
        Image Icono_atras;
        Label Titulo_Pagina,Titulo_Nota1, Titulo_Nota2, Titulo_Nota3, Resultado_Nota1, Resultado_Nota2, Resultado_Nota3,Titulo_ResultadoFinal, Resultado_NotaFinal;
        TapGestureRecognizer tap_gesto_atrasNotas;
        




        public DetalleNotas()
        {
            {

                NavigationPage.SetHasNavigationBar(this, false);
                CrearVistas();
                AgregarVistas();
                AgregarEventos();
            }

            void CrearVistas()

            {
                Vista_PrincipalNotas = new RelativeLayout();

                BarraNavegacion = new BoxView
                {
                    BackgroundColor = Core.Principal
                };

                Titulo_Pagina = new Label
                {
                    Text = "Detalle Notas",
                    FontSize = 22,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };
                

                Icono_atras = new Image
                {
                    Source = Core.Icono_atras
                };

                tap_gesto_atrasNotas = new TapGestureRecognizer
                {
                };

              

                Titulo_Nota1 = new Label
                {
                    Text = "Primer Corte",
                    FontSize = 13,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };


                Nota1 = new BoxView
                {
                    BackgroundColor = Core.Navegacion,
                    CornerRadius = 10
                };

                Resultado_Nota1 = new Label
                {
                    Text = "5.0",
                    FontSize = 35,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };


                Titulo_Nota2 = new Label
                {
                    Text = "Segundo Corte",
                    FontSize = 13,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };

                Nota2 = new BoxView
                {
                    BackgroundColor = Core.Navegacion,
                    CornerRadius = 10
                };

                Resultado_Nota2 = new Label
                {
                    Text = "4.0",
                    FontSize = 35,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };

              

                Titulo_Nota3 = new Label
                {
                    Text = "Tercer Corte",
                    FontSize = 13,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };

                Nota3 = new BoxView
                {
                    BackgroundColor = Core.Navegacion,
                    CornerRadius = 10
                };          
               
                Resultado_Nota3 = new Label
                {
                    Text = "4.8",
                    FontSize = 35,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };

               

                Resultado_NotaFinal = new Label
                {
                    Text = "RESULTADO FINAL",
                    FontSize = 13,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };

                Titulo_ResultadoFinal = new Label
                {
                    Text = "RESULTADO FINAL",
                    FontSize = 13,
                    TextColor = Core.Textos,
                    HorizontalTextAlignment = TextAlignment.Center
                };

                Resultado_NotaFinal = new Label
                {
                    Text = "4.0",
                    FontSize = 35,
                    TextColor = Core.Botones,
                    HorizontalTextAlignment = TextAlignment.Center
                };
            }

            void AgregarVistas()

            {

                Vista_PrincipalNotas.Children.Add(BarraNavegacion,

                       Constraint.RelativeToParent((p) => { return 0; }),
                       Constraint.RelativeToParent((p) => { return 0; }),
                       Constraint.RelativeToParent((p) => { return p.Width; }),
                       Constraint.RelativeToParent((p) => { return p.Height * 0.083; }));

                Vista_PrincipalNotas.Children.Add(Titulo_Pagina,

                      Constraint.RelativeToParent((p) => { return 0; }),
                      Constraint.RelativeToParent((p) => { return p.Height * 0.022; }),
                      Constraint.RelativeToParent((p) => { return p.Width; }));

                Vista_PrincipalNotas.Children.Add(Icono_atras,

                       Constraint.RelativeToParent((p) => { return p.Width * 0; }),
                       Constraint.RelativeToParent((p) => { return 0; }),
                       Constraint.RelativeToParent((p) => { return p.Width * 0.149; }),
                       Constraint.RelativeToParent((p) => { return p.Height * 0.083; }));

             

                Vista_PrincipalNotas.Children.Add(Titulo_Nota1,

                     Constraint.RelativeToParent((p) => { return 46; }),
                     Constraint.RelativeToParent((p) => { return 108; }),
                     Constraint.RelativeToParent((p) => { return p.Width * 0.28; }),
                     Constraint.RelativeToParent((p) => { return p.Height * 0.029; }));

                Vista_PrincipalNotas.Children.Add(Nota1,

                       Constraint.RelativeToParent((p) => { return 40; }),
                       Constraint.RelativeToParent((p) => { return 128; }),
                       Constraint.RelativeToParent((p) => { return p.Width * 0.309; }),
                       Constraint.RelativeToParent((p) => { return p.Height * 0.173; }));

                Vista_PrincipalNotas.Children.Add(Resultado_Nota1,

                   Constraint.RelativeToParent((p) => { return 40; }),
                   Constraint.RelativeToParent((p) => { return 160; }),
                   Constraint.RelativeToParent((p) => { return p.Width * 0.309; }),
                   Constraint.RelativeToParent((p) => { return p.Height * 0.061; }));


                Vista_PrincipalNotas.Children.Add(Titulo_Nota2,

                     Constraint.RelativeToParent((p) => { return 216; }),
                     Constraint.RelativeToParent((p) => { return 108; }),
                     Constraint.RelativeToParent((p) => { return p.Width * 0.28; }),
                     Constraint.RelativeToParent((p) => { return p.Height * 0.029; }));

                Vista_PrincipalNotas.Children.Add(Nota2,

                      Constraint.RelativeToParent((p) => { return 210; }),
                      Constraint.RelativeToParent((p) => { return 128; }),
                      Constraint.RelativeToParent((p) => { return p.Width * 0.309; }),
                      Constraint.RelativeToParent((p) => { return p.Height * 0.173; }));

                Vista_PrincipalNotas.Children.Add(Resultado_Nota2,

                     Constraint.RelativeToParent((p) => { return 210; }),
                     Constraint.RelativeToParent((p) => { return 160; }),
                     Constraint.RelativeToParent((p) => { return p.Width * 0.309; }),
                     Constraint.RelativeToParent((p) => { return p.Height * 0.061; }));

             

                Vista_PrincipalNotas.Children.Add(Nota3,

                      Constraint.RelativeToParent((p) => { return 129.5; }),
                      Constraint.RelativeToParent((p) => { return 286; }),
                      Constraint.RelativeToParent((p) => { return p.Width * 0.309; }),
                      Constraint.RelativeToParent((p) => { return p.Height * 0.173; }));
                                          
                Vista_PrincipalNotas.Children.Add(Titulo_Nota3,

                     Constraint.RelativeToParent((p) => { return 137; }),
                     Constraint.RelativeToParent((p) => { return 266; }),
                     Constraint.RelativeToParent((p) => { return p.Width * 0.28; }),
                     Constraint.RelativeToParent((p) => { return p.Height * 0.029; }));

                Vista_PrincipalNotas.Children.Add(Resultado_Nota3,

                     Constraint.RelativeToParent((p) => { return 129.5; }),
                     Constraint.RelativeToParent((p) => { return 313; }),
                     Constraint.RelativeToParent((p) => { return p.Width * 0.309; }),
                     Constraint.RelativeToParent((p) => { return p.Height * 0.061; }));

              

                Vista_PrincipalNotas.Children.Add(Titulo_ResultadoFinal,

                 Constraint.RelativeToParent((p) => { return 104; }),
                 Constraint.RelativeToParent((p) => { return 527; }),
                 Constraint.RelativeToParent((p) => { return p.Width * 0.458; }),
                 Constraint.RelativeToParent((p) => { return p.Height * 0.029; }));

                Vista_PrincipalNotas.Children.Add(Resultado_NotaFinal,

                 Constraint.RelativeToParent((p) => { return 132; }),
                 Constraint.RelativeToParent((p) => { return 547; }),
                 Constraint.RelativeToParent((p) => { return p.Width * 0.309; }),
                 Constraint.RelativeToParent((p) => { return p.Height * 0.061; }));


                Content = Vista_PrincipalNotas;
            }

            void AgregarEventos()

            {
                Icono_atras.GestureRecognizers.Add(tap_gesto_atrasNotas);
                tap_gesto_atrasNotas.Tapped += Tap_gesto_atrasNotas_Tapped;
            }

        }
        
        private async void Tap_gesto_atrasNotas_Tapped(object sender, EventArgs e)
        {                 
            await Navigation.PopAsync();
        }
    }
}
         
        

        
       
        
       
    



