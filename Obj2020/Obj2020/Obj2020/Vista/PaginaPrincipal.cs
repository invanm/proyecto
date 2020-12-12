using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace Obj2020
{
    class PaginaPrincipal : ContentPage
    {
        RelativeLayout Vista_Principal;
        BoxView barra_navegacion;
        Image Icono_salir, Icono_atras;
        Label titulo_pagina;
        TapGestureRecognizer Tap_gesto_atras;
        List<Estudiante> Lista_estudiantes;
        ListView ListViewEstudiantes;

        public PaginaPrincipal(Usuario My_User_second)
        {
           // NavigationPage.SetHasNavigationBar(this, false);
            CrearVistas(My_User_second);
            AgregarVistas();
            AgregarEventos();
        }
        void CrearVistas(Usuario my_User_Last)
        {
            Title = "Pagina Principal";
            Tap_gesto_atras = new TapGestureRecognizer();

            Lista_estudiantes = new List<Estudiante>();
            LlenadoEstudiantesQuemados();

            Vista_Principal = new RelativeLayout();
            barra_navegacion = new BoxView
            {
                BackgroundColor = Core.Navegacion
            };

            Icono_salir = new Image
            {
                Source = Core.Icono_salir
            };

            Icono_atras = new Image
            {
                Source = Core.Icono_atras
            };

            titulo_pagina = new Label
            {
                Text = "Pagina Principal",
                FontSize = 21,
                TextColor = Core.Textos,
                HorizontalTextAlignment = TextAlignment.Center

            };

            ListViewEstudiantes = new ListView
            {
                ItemsSource = Lista_estudiantes,
                ItemTemplate = new DataTemplate(typeof(CeldaEstudiantes)),
                RowHeight = 80
            };
        }

        void AgregarVistas()
        {
            Icono_salir.GestureRecognizers.Add(Tap_gesto_atras);

            //Vista_Principal.Children.Add(barra_navegacion,
              //         Constraint.RelativeToParent((p) => { return 0; }), //x posicion
              //         Constraint.RelativeToParent((p) => { return 0; }), //y pososcion 
                //       Constraint.RelativeToParent((p) => { return p.Width; }), //ancho del control 
                  //     Constraint.RelativeToParent((p) => { return p.Height * 0.083; })); // alto del control 

            //Vista_Principal.Children.Add(titulo_pagina,
              //       Constraint.RelativeToParent((p) => { return 0; }),
                //     Constraint.RelativeToParent((p) => { return p.Height * 0.022; }),
                  //   Constraint.RelativeToParent((p) => { return p.Width; }));

            //Vista_Principal.Children.Add(Icono_salir,
              //         Constraint.RelativeToParent((p) => { return p.Width * 0.850; }),
                //       Constraint.RelativeToParent((p) => { return 0; }),
                  //     Constraint.RelativeToParent((p) => { return p.Width * 0.149; }),
                    //   Constraint.RelativeToParent((p) => { return p.Height * 0.083; }));

            Vista_Principal.Children.Add(Icono_atras,

                      Constraint.RelativeToParent((p) => { return p.Width * 0; }),
                      Constraint.RelativeToParent((p) => { return 0; }),
                      Constraint.RelativeToParent((p) => { return p.Width * 0.149; }),
                      Constraint.RelativeToParent((p) => { return p.Height * 0.083; }));

            Vista_Principal.Children.Add(ListViewEstudiantes,

                 Constraint.RelativeToParent((p) => { return 0; }),
                 Constraint.RelativeToParent((p) => { return p.Height * 0.104; }),
                 Constraint.RelativeToParent((p) => { return p.Width; }),
                 Constraint.RelativeToParent((p) => { return p.Height * 0.824; }));






            Content = Vista_Principal;

        }

        void AgregarEventos()
        {
            Tap_gesto_atras.Tapped += Tap_gesto_atras_Tapped;
            ListViewEstudiantes.ItemSelected += ListViewEstudiantes_ItemSelected;
            ListViewEstudiantes.ItemTapped += ListViewEstudiantes_ItemTapped;
        }



        private async void ListViewEstudiantes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Seleccion", "Estudiantes !!", "Aceptar");
        }

        private async void Tap_gesto_atras_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void ListViewEstudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        void LlenadoEstudiantesQuemados()


        {

            Lista_estudiantes.Add(new Estudiante
            {
                Nombre = "carolina",
                Apellido = "quintero",
                Docente = "daniel carvajal ",
                Materia = "literatura ",
                Not1 = 1,
                Not2 = 2,
                Not3 = 3

            });
            {

                Lista_estudiantes.Add(new Estudiante
                {
                    Nombre = "Lina",
                    Apellido = "Marcela",
                    Docente = " villamizar",
                    Materia = "fisica",
                    Nota = "4.6"

                });

                Lista_estudiantes.Add(new Estudiante
                {
                    Nombre = "carlos",
                    Apellido = "gutierres",
                    Docente = "lisa sofia",
                    Materia = "Etica",
                    Nota = "5.0"

                });

                Lista_estudiantes.Add(new Estudiante
                {
                    Nombre = "Alejandro",
                    Apellido = "Ochoa",
                    Docente = "Daniel arango",
                    Materia = "Español",
                    Nota = "4.5"

                });
            }
        }
    }
}
