using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using HomeAssignment.Models;

namespace HomeAssignment.Controllers
{
    [EnableCors("*", "*", "*")]
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