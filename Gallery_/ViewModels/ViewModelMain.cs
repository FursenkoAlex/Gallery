using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Gallery_.Commands;
using Gallery_.Model;

namespace Gallery_.ViewModels
{
    class ViewModelMain : ViewModelBase
    {

        public ObservableCollection<ImagesViewModel> imagesList { get; set; }

        MyImages image = new MyImages();
        public ViewModelMain()
        {
            imagesList = new ObservableCollection<ImagesViewModel>();
            i = 0;
        }

        public List<string> listPath = new List<string>();

        private int i;

        public int Index
        {
            get { return i; }
            set
            {
                i = value;
                OnPropertyChanged();
            }
        }

        private ICommand download;

        public ICommand Download
        {
            get
            {
                if (download == null)
                    download = new OpenFolderCommand(() => DownloadImage());
                return download;
            }
        }

        public void DownloadImage() 
        {
            var folder = new OpenFileDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string str = folder.FileName;
                FileInfo f = new FileInfo(folder.FileName);
                DateTime creationTime = f.CreationTime;
                image.Date = creationTime.ToShortDateString();
                imagesList.Add(new ImagesViewModel(new BitmapImage(new Uri(str)),creationTime.ToString(), f.Name));
            }
        }

        private OpenFolderCommand next;

        public ICommand Next
        {
            get
            {
                if (next == null)
                    next = new OpenFolderCommand(() =>
                    {
                        if (Index < imagesList.Count)
                            Index++;
                    });
                return next;
            }
        }

        private ICommand preview;

        public ICommand Preview
        {
            get
            {
                if (preview == null)
                    preview = new OpenFolderCommand(() =>
                    {
                       if (Index > 0)
                            Index--;
                    });
                return preview;
            }
        }


        private ICommand start;
        public ICommand Start
        {
            get
            {
                if (start == null)
                    start = new OpenFolderCommand(() => Index = 0);
                return start;
            }
        }

        private ICommand end;

        public ICommand End
        {
            get
            {
                if (end == null)
                    end = new OpenFolderCommand(() => Index = imagesList.Count - 1);
                return end;
            }
        }


        public string CreationDate
        {
            get
            {
                return image.Date;
            }
            set
            {
                image.Date = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return image.Name; }
            set
            {
                image.Name = value;
                OnPropertyChanged();
            }
        }



    }
}
