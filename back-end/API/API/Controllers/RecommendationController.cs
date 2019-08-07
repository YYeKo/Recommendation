using BL;
using DTO;
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
    [RoutePrefix("api/recommendation")]
    public class RecommendationController : ApiController
    {
        [HttpPost]
        [Route("createRecommendation")]
        public IHttpActionResult CreateRecommendation(RecommendationsDTO recommendation)
        {
            return Ok(RecommendationService.CreateRecommendation(recommendation));
        }

        [HttpGet]
        [Route("getFilteredProfessionals/{profession}/{city}")]
        public IHttpActionResult GetFilteredProfessionals([FromUri]int profession,[FromUri]int city)
        {
            return Ok(RecommendationService.GetFilteredProfessionals(profession,city));
        }

        [HttpGet]
        [Route("getRecommendationsOfProf/{id}")]
        public IHttpActionResult GetRecommendationsOfProf([FromUri]int id)
        {
            return Ok(RecommendationService.GetRecommendationsOfProf(id));
        }
    }
}
