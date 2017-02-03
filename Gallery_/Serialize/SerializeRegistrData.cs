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
    class SerializeRegistrData : IRegistrDataSerialize
    {
        private FileStream stream;
        private XmlSerializer serialize;
        public void SaveRegistrDataCollection(ICollection<User> users)
        {
            stream = new FileStream("../data.xml", FileMode.Create);
            serialize = new XmlSerializer(typeof(List<User>));
            serialize.Serialize(stream, users);
            stream.Close();
        }

        public ICollection<User> LoadRegistrDataCollection()
        {
            stream = new FileStream("../data.xml", FileMode.Open);
            serialize = new XmlSerializer(typeof(List<User>));
            List<User> listUser = (List<User>)serialize.Deserialize(stream);
            stream.Close();
            return listUser;
        }
    }
}
