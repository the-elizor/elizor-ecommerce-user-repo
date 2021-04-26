using elizor.ecommerce.user.contracts.Repositories;
using elizor.ecommerce.user.dbcontext.tables;
using elizor.ecommerce.user.entities.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elizor.ecommerce.user.data.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly UserContext _userContext;
        public LoginRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public MyGuest SaveMyGuest(MyGuest myguests)
        {
            try
            {
                var myguest = new Myguests { Email = myguests.Email, Firstname = myguests.Firstname, Lastname = myguests.Lastname, Id = 1 };

                var hel = _userContext.Myguests.FirstOrDefault();
                _userContext.Myguests.Add(myguest);
                _userContext.SaveChanges();
                return myguests;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
