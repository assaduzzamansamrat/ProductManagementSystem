using PMSEntity;
using PMSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSRepository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public List<User> Search(string keyword)
        {
            try
            {
                List<User> userList = new List<User>();
                userList.AddRange(this.GetAll().Where(p => p.FirstName.Contains(keyword)).ToList());
                userList.AddRange(this.GetAll().Where(p => p.LastName.Contains(keyword)).ToList());
                return userList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
