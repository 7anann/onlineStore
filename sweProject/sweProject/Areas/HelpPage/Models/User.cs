﻿
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
        
        public string logIn(User u)
        {
          
            List<User> user = Adminstrator.getAllUsers();
            for (int i=0; i< user.Count;i++)
            {
               if (user[i].username == username && user[i].password == password)
                {
                    return "Logged in successfully.";
                }
            }
            return "Wrong username or password.";
            
        }
        
    }
}
