
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sweProject.Models;


namespace sweProject.Controllers
{
    public class UserController : ApiController
    {
        
       User globalUser = new User();

       
        [HttpPost]
        [Route("reg/")]
        public IHttpActionResult addUser(User u)
        {
           globalUser = u;
           return Ok(u.register());
        }

    [HttpGet]
        [Route("get/")]
        public IHttpActionResult getAllUsers(User use) 
        {

            List<User> u = Adminstrator.getAllUsers();
            for (int i = 0; i < u.Count; i++)
            {
                if (u[i].username == use.username && u[i].password == use.password) //if logged in then
                {
                   
                    if ( u[i].type == use.type  && use.type =="Admin") //check if this user is admin 
                    {
                        return Ok(Models.Adminstrator.getAllUsers());
                    }
                }
            }

            return Ok("You must be an authorized user to use this functionality.");
        }
        
        [HttpPost]
        [Route("login/")]
        public IHttpActionResult logIn(User u)
        {         
            return Ok(u.logIn(u));
        }
    }
}


