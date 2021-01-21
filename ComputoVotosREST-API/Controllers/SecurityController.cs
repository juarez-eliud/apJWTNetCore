using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using ComputoVotosREST_API.Models;
using ComputoVotosREST_API.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComputoVotosREST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : BaseApiController
    {
        private JwtSettings _settings;
        public SecurityController(JwtSettings settings)
        {
            _settings = settings;
        }


        [HttpPost("login")]
        public IActionResult Login([FromBody]AppUser user)
        {

            IActionResult ret = null;
            AppUserAuth auth = new AppUserAuth();
            SecurityManager mgr = new SecurityManager(_settings);

            auth = mgr.ValidateUser(user);
            if (auth.IsAuthenticated)
            {
                ret = StatusCode(200, auth);
            }
            else
            {
                ret = StatusCode(404, "Invalid User Name/Password.");
            }

            return ret;
        }
    }
}