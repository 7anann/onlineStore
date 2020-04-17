using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sweProject.Models
{
    public class Administrator
    {
        public static List<User> getAllUsers()
        {
            usersDatabaseDataContext db = new usersDatabaseDataContext();
            storeTable obj = new storeTable();
            List<storeTable> list = (from u in db.storeTables select u).ToList<storeTable>();
            List<User> users = new List<User>();
            for (int i = 0; i < list.Count; i++)
            {
                User u = new User();
                u.username = list[i].username;
                u.password = list[i].password;
                u.email = list[i].email;
                u.type = list[i].type;

                users.Add(u);

            }

            return users;
        }
    }
}
