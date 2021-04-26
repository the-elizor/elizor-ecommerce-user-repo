using elizor.ecommerce.user.entities.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.contracts.Repositories
{
    public interface ILoginRepository
    {
        MyGuest SaveMyGuest(MyGuest myguests);
    }
}
