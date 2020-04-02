
using System;
using System.Collections.Generic;
using System.Linq;


namespace sweProject.Models
{
    public class User
    {
        public string username, password, email;
        public bool register()
        {
            usersDatabaseDataContext db = new usersDatabaseDataContext();
            storeTable obj = new storeTable();
            obj.username = this.username;
            obj.password = this.password;
            obj.email = this.email;
            db.storeTables.InsertOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }
        
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
                 u.password = "***";
                 u.email = list[i].email;
                 users.Add(u);

            }

            return users;
        }

    }
}
