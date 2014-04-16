using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestWebEngine.Web.Controllers.QuestionAPI
{
    public class SingleAnswerTypeController : ApiController
    {
        // GET: api/SingleAnswerType
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SingleAnswerType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SingleAnswerType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SingleAnswerType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SingleAnswerType/5
        public void Delete(int id)
        {
        }
    }
}
