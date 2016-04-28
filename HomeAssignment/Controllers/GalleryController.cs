using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HomeAssignment.Models;

namespace HomeAssignment.Controllers
{
    public class GalleryController : ApiController
    {
        // GET api/gallery
        public IEnumerable<Image> Get()
        {
            var repository = new ImageRepository();
            return repository.FetchAllImage();
        }

        // GET api/gallery/5
        public string Get(int id)
        {
            return "value";
        }

       
    }
}
