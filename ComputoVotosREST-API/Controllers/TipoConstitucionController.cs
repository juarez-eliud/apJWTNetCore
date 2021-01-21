using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputoVotosREST_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputoVotosREST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TipoConstitucionController : BaseApiController
    {

        [HttpGet]
        [Authorize(Policy = "CanAccessProducts")]
        public IActionResult Get()
        {
            IActionResult ret = null;
            List<TipoConstitucion> list = new List<TipoConstitucion>();
            List<Coalicion> coal = new List<Coalicion>();

            try
            {
                using (var db = new ComVotDbContext())
                {
                    if (db.Constituciones.Count() > 0)
                    {
                        // NOTE: Declare 'list' outside the using to avoid 
                        // it being disposed before it is returned.
                        list = db.Constituciones.OrderBy(p => p.Nombre).ToList();
                       // coal = db.Coaliciones.FromSqlRaw("exec sp_listado_coaliciones").ToList();

                        //Console.WriteLine(coal.Select(var ab => new Coalicion() {
                        //}));


                        ret = StatusCode(StatusCodes.Status200OK, list);
                    }
                    else
                    {
                        ret = StatusCode(StatusCodes. Status404NotFound,
                                       "Can't Find Categories");
                    }
                }
            }
            catch (Exception ex)
            {
                ret = HandleException(ex,
                     "Exception trying to get all Categories");
            }

            return ret;
        }
    }
}