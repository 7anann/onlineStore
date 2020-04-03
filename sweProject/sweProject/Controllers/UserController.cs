using System;
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

        public void getUser()
        {

        }
       
        [HttpPost]
        [Route("reg/")]
        public IHttpActionResult addUser(User u)

    
      [HttpGet]
        [Route("get/")]
        public IHttpActionResult getAllUsers()
        {
            List<User> u = Models.User.getAllUsers();
                    return Ok(Models.User.getAllUsers());
           
        }
    }
}

