using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{

    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/professions")]
    public class ProfessionsController : ApiController
    {
        [HttpGet]
        [Route("getProfessions")]
        public IHttpActionResult GetProfessions()
        {
            return Ok(ProfessionsService.GetProfessions());
        }
    }
}
