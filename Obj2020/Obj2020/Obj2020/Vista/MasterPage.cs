using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Obj2020
{
    public class MasterPage : MasterDetailPage

    {
        public MasterPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Page _PaginaPrincipal = new VistaMenuMaster();
            Master = _PaginaPrincipal;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PaginaPrincipal)))
            {
                BarBackgroundColor = Core.Principal,
                BarTextColor = Color.White

            };

        }
    }
}
