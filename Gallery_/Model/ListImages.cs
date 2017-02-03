using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery_.Model
{
    [Serializable]
    class ListImages
    {

        public List<MyImages> listImages { get; set; } = new List<MyImages>();

        public void AddListUsers(MyImages image)
        {
            listImages.Add(image);
        }

        public void SaveImages(IImageSerialize imageSerialize)
        {
            imageSerialize.SaveImageCollection(listImages);
        }

        public void LoadImages(IImageSerialize imageSerialize)
        {
            listImages = imageSerialize.LoadImagesCollection() as List<MyImages>;
        }
    }
}
