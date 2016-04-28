using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using HomeAssignment.Models;

namespace HomeAssignment.Controllers
{
    [EnableCors("*", "*", "*")]
    public class GalleryController : ApiController
    {
        // GET api/gallery
        public IHttpActionResult Get()
        {
            var repository = new ImageRepository();
            return Ok(repository.FetchAllImage().AsQueryable());
        }
        public IHttpActionResult Get(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return BadRequest("Search term cannot be empty.");
            }
            var repository = new ImageRepository();
            var images= repository.FetchAllImage();
            return Ok(images.Where(p => p.Title.Contains(search)).AsQueryable());
        }
        
    }
}