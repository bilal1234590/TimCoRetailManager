using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;
using AuthorizeAttribute = System.Web.Http.AuthorizeAttribute;

namespace TRMDataManager.Controllers
{
    [Authorize]

    public class UserController : ApiController
    {
        public List<UserModel> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId);

            
        

        }
    }
}
