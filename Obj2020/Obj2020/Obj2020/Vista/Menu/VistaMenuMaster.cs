using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Obj2020
{
    public class VistaMenuMaster : ContentPage
    {
        RelativeLayout Vista;
        Button Titulo;
        ListView ListaMenu;
        List<MasterMenu> Menu;
        //Image notas


        public VistaMenuMaster()

        {
            Title = "Mi Vista";
            CrearVistas();
            AgregarVista();
            AgregarEventos();

            void CrearVistas()
            {

                Titulo = new Button
                {
                    BackgroundColor = Core.Navegacion,
                    Text = "SOY UTAP",
                    FontSize = 25,
                    CornerRadius = 20,
                    BorderWidth = 2,
                    BorderColor = Core.Principal,
                    TextColor = Core.Textos,
                };

                Menu = new List<MasterMenu>
                 {
                new MasterMenu {Titulo="Mis Materias y Notas",Icono="Icono.png",IconoVisible=true},
                new MasterMenu {Titulo="Mi Documentacion ",Icono="ic_add.png",IconoVisible=true},
                new MasterMenu {Titulo="Cerrar sesion",Icono="Cerrar_sesion.png",IconoVisible=false},
                 };

                ListaMenu = new ListView
                {
                    ItemsSource = Menu,
                    ItemTemplate = new DataTemplate(typeof(EstiloTemplate)), 
                    RowHeight = 70,
                    SeparatorColor = Core.Textos
                };



                Vista = new RelativeLayout { BackgroundColor = Core.Navegacion };


            }

            void AgregarVista()
            {
                Vista.Children.Add(Titulo,
                Constraint.RelativeToParent((p) => { return p.Width * 0.070; }),
                Constraint.RelativeToParent((p) => { return p.Height * 0.150; }),
                Constraint.RelativeToParent((p) => { return p.Width * 0.850; }),
                Constraint.RelativeToParent((p) => { return p.Height * 0.200; }));


                Vista.Children.Add(ListaMenu,
                Constraint.RelativeToParent((p) => { return p.Width * 0.070; }),
                Constraint.RelativeToParent((p) => { return p.Height * 0.400; }),
                Constraint.RelativeToParent((p) => { return p.Width * 0.850; }),
                Constraint.RelativeToParent((p) => { return p.Height * 0.700; }));
                Content = Vista;
            }

        }
        void AgregarEventos()
        {
            ListaMenu.ItemSelected += ListaMenu_ItemSelected;
            ListaMenu.ItemTapped += ListaMenu_ItemTapped;
        }

        private void ListaMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        private async void ListaMenu_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            switch (((MasterMenu)e.Item).Titulo)
            {
                case "Mis Materias y Notas":

                    break;

                case "Mi Documentacion":
                    break;

                case "Cerrar sesion":

                    await App.Current.MainPage.Navigation.PushAsync(new Login());
                    Page pagina = App.Current.MainPage.Navigation.NavigationStack[0];
                    Navigation.RemovePage(pagina);
                    break;

                default:
                    break;
            }
        }
    }
}