using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Gallery_.Model;

namespace Gallery_.ViewModels
{
    class ImagesViewModel:ViewModelBase
    {
        private ImageSource imagesSource;

        public string Date { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public ImageSource ImagesSource
        {
            get
            {
                return imagesSource;
            }
            set
            {
                imagesSource = value;
                OnPropertyChanged();
            }
        }

        public ImagesViewModel(ImageSource i, string d, string n)
        {
            imagesSource = i;
            Date = d;
            Name = n;

        }
    }
}
