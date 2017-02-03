using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gallery_.Model;

namespace Gallery_
{
    interface IImageSerialize
    {
        void SaveImageCollection(ICollection<MyImages> images);
        ICollection<MyImages> LoadImagesCollection();
    }
}
