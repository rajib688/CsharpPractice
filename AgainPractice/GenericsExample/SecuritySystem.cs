using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class SecuritySystem<TUser> where TUser : IUser
    {
        private IUser _user;
        public Tkey Open<Tkey>(Tkey key) where Tkey : class/*, new()*/
        {
            Tkey anotherkey = default(Tkey);

            return anotherkey;
        }

    }
}
