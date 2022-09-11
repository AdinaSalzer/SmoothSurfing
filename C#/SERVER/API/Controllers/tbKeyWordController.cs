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
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/KeyWord")]
    public class TbKeyWordController : ApiController
    {
        [Route("getKeyWordId")]
        [HttpGet]
        public IHttpActionResult GetKeyWordId()
        {
            return Ok("123");
        }

        [Route("getSenId")]
        [HttpGet]
        public IHttpActionResult GetSenId()
        {
            return Ok("456");
        }
        [Route("AddKeyWord"), HttpPost]
        public IHttpActionResult AddKeyWord(KeyWordDTO keyWord)
        {
            BL.KeyWordBL.AddKeyWord(keyWord);
            return Ok(true);
        }

        [Route("FindKeyWord"), HttpGet]
        public IHttpActionResult FindKeyWord( string sentance)
        {
            for (int i = 0; i < sentance.Length; i++)

            {if (sentance[i] == Smoothsurfing.Select("wordId like '%" + GetKeyWordId() + "%'"))
                {

                }
                

            }

        }
    }
}
