using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DTO;

namespace API.Controllers
{
    [EnableCors(origins: "*", methods: "*", headers: "*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {

        [HttpGet]
        [Route("login/{userName}/{userPassword}")]
        public IHttpActionResult LogIn([FromUri]string userName,[FromUri]string userPassword)
        {
                return Ok(UserService.LogIn(userName, userPassword));
        }

        [HttpPost]
        [Route("registerUser")]
        public IHttpActionResult RegisterUser(UsersDTO user)
        {
            if (UserService.IsExistsPassword(user.UserPassword,user.UserId))
                return BadRequest("סיסמה בשימוש");
            return Ok(UserService.RegisterUser(user));
        }

        [HttpPost]
        [Route("registerProfessional")]
        public IHttpActionResult RegisterProfessional(ProfessionData professional)
        {
            if (UserService.IsExistsPassword(professional.professional.UserPassword,professional.professional.UserId))
                return BadRequest("סיסמא קיימת");
            return Ok(UserService.RegisterProfessional(professional));
        }

        [HttpGet]
        [Route("getCities")]
        public IHttpActionResult GetCities()
        {
            return Ok(UserService.GetCitiyList());
        }

        [HttpGet]
        [Route("getProfessionals")]
        public IHttpActionResult GetProfessionals()
        {
            return Ok(BL.UserService.GetProfessionalList());
        }

        [HttpGet]
        [Route("getProfessionalById/{id}")]
        public IHttpActionResult GetProfessionalById([FromUri]int id)
        {
            UsersDTO p= UserService.GetProfessionalById(id);
            if (p is ProfessionalDTO)
            return Ok(p as ProfessionalDTO);
            return Ok(p);
        }
        [HttpGet]
        [Route("getProfessionalNameById/{id}")]
        public IHttpActionResult GetProfessionalNameById([FromUri]int id)
        {
            return Ok(UserService.GetProfessionalNameById(id));
        }
    }
}
