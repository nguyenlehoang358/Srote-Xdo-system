using STORE_X.DAL;
using STORE_X.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORE_X.Ctrl
{
    public class User_BLL
    {
        private User_DAL userDAL = new User_DAL();

        public List<User> GetUsers()
        {
            return userDAL.GetUsers();
        }

        public void AddUser(User user)
        {
            userDAL.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            userDAL.UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            userDAL.DeleteUser(userId);
        }
    }
}
