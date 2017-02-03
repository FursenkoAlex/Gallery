using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery_.Model
{
    [Serializable]
    class ListUsers
    {
        public List<User> listUser { get; set; } = new List<User>();

        public void AddListUsers(User user)
        {
            listUser.Add(user);
        }

        public void SaveUsers(IRegistrDataSerialize dataSerialize)
        {
            dataSerialize.SaveRegistrDataCollection(listUser);
        }

        public void LoadUsers(IRegistrDataSerialize dataSerialize)
        {
            listUser = dataSerialize.LoadRegistrDataCollection() as List<User>;
        }
    }
}
