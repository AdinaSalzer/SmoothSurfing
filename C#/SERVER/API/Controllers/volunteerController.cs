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
    [EnableCors("*","*","*")]
    [RoutePrefix("api/volunteer")]
    public class VolunteerController : ApiController

    {
        [Route("getVolunteer")]
        [HttpGet]
        public IHttpActionResult GetVolunteer()
        {
            return Ok("adina sara levin");
        }

        //[Route("getlastname")]
        //[HttpGet]
        //public IHttpActionResult GetLestName()
        //{
        //    return Ok("levin");
        //}
        [Route("AddVoLunteer"),HttpPost]
        public IHttpActionResult AddVoLunteer(VolunteerDTO volunteer)
        {
             BL.VolunteerBL.AddVolunteer(volunteer);
            return Ok(true);
        }
            
    }
}
