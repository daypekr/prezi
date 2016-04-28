using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeAssignment.Controllers
{
    public class GalleryController : ApiController
    {
        // GET api/gallery
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/gallery/5
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
