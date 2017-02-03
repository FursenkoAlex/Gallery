using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Gallery_.Model;

namespace Gallery_.Serialize
{
    class ImageSerialize : IImageSerialize

    {
        private FileStream stream;  
        private XmlSerializer serialize;
        public void SaveImageCollection(ICollection<MyImages>users)
        {
            stream = new FileStream("../image.xml", FileMode.Create);
            serialize = new XmlSerializer(typeof(List<MyImages>));
            serialize.Serialize(stream, users);
            stream.Close();
        }

        public ICollection<MyImages> LoadImagesCollection()
        {
            stream = new FileStream("../image.xml", FileMode.Append);
            serialize = new XmlSerializer(typeof(List<MyImages>));
            List<MyImages> listUser = (List<MyImages>)serialize.Deserialize(stream);
            stream.Close();
            return listUser;
        }
    }
}
