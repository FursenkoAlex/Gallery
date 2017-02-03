using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gallery_.Model;

namespace Gallery_
{
    interface IRegistrDataSerialize
    {
        void SaveRegistrDataCollection(ICollection<User> users);
        ICollection<User> LoadRegistrDataCollection();
    }
}
