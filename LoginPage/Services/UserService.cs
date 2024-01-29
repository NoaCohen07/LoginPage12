using LoginPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage.Services
{
    public class UserList
    {
        public List<User> Users { get; private set; }
        public UserList()
        {
            this.Users = new List<User>();
            FillList();
        }
        private void FillList()
        {
            Users.Add(new User("Noa","noa2007"));
           
            Users.Add(new User ("Ori","origeva13"));
            Users.Add(new User("Marom", "maromhaijan2008"));
           
            Users.Add(new User("Amit","batzir2007"));
        }

    }
    public class UserService
    {
        
        public UserService()
        {
            users = new UserList().Users;
        }
        List<User> users;
        static Random random = new Random();
        public User GetRandomUser()
        {
            int index = random.Next(0, users.Count);
            return users[index];
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void RemoveUser(User user)
        {
            users.Remove(user);
        }
       
        public bool Login(User u)
        {
            int length=users.Count;
            for(int i=0; i<length; i++)
            {
                if (users[i].userName == u.userName && users[i].password == u.password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
