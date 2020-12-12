using Obj2020;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Xamarin.Forms;

namespace Obj2020
{
    public class App : Application
    {

       public static Usuario sesion;

        public App()
        {
            sesion = new Usuario
            {
                Nombre = "Ingrid",
                Apellido = "Vanessa",
                Correo = "Ingrid@gmail.com",
                User_Name = "ING"

            };

            MainPage = new NavigationPage(new Login());

        }
    }
}