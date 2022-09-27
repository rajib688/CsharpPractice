using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class SecuritySystem<TUser> where TUser : IUser
    {
        private TUser user;
 
        public TKey Open<TKey>(TKey key) where TKey: class
        {
            TKey anotherkey = default(TKey);

            return anotherkey;
        }
    }
}
