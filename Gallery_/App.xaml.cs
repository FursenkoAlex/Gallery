using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Gallery_.ViewModels;
using Gallery_.Views;
using Gallery_.Model;

namespace Gallery_  
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            ViewRegistrAuthor view = new ViewRegistrAuthor();
            ViewModelRegistrAuthoriz viewModelRegistrAuthoriz = new ViewModelRegistrAuthoriz(view);

            view.DataContext = viewModelRegistrAuthoriz;
            view.Show();

            //ViewGallery v = new ViewGallery();
            //ViewModelMain vv = new ViewModelMain(v);
            //v.DataContext = vv;
            //v.Show();

        }
    }
}
