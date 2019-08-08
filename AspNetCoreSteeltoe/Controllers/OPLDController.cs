using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreSteeltoe.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSteeltoe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OPLDController : ControllerBase
    {
        private readonly IOPLDQueryService opldQueryService;

        public OPLDController(IOPLDQueryService opldQueryService)
        {
            this.opldQueryService = opldQueryService;
        }


        // GET api/values
        [HttpGet]
        [Route("GetOPLDPackageTrackingNumber")]
        public ActionResult GetOPLDPackageTrackingNumber()
        {
            return Ok(opldQueryService.GetOPLDPackageTrackingNumber());
        }

        [HttpGet]
        [Route("GetMultipleTrackingNumber/{count}")]
        public ActionResult GetMultipleTrackingNumber(int count)
        {
            return Ok(opldQueryService.GetMultipleTrackingNumber(count));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
