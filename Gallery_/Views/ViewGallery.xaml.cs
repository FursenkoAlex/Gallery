using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Microsoft.Win32;

namespace Gallery_.Views
{
    /// <summary>
    /// Interaction logic for ViewGallery.xaml
    /// </summary>
    public partial class ViewGallery : MetroWindow
    {
        public ViewGallery()
        {
            InitializeComponent();
        }

        private void MetroWindow_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
