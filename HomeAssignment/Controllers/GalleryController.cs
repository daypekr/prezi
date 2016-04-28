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
        public IHttpActionResult Get(string order)
        {
            var repository = new ImageRepository();

            IEnumerable<Image> images = repository.FetchAllImage();
            images = applyOrder(images, order);
            return Ok(images.AsQueryable());
        }
        public IHttpActionResult Get(string order, string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return BadRequest("Search term cannot be empty.");
            }
            var repository = new ImageRepository();
            var images= repository.FetchAllImage().Where(p => p.Title.Contains(search));
             images = applyOrder(images, order);
            return Ok(images.AsQueryable());
        }

        private IEnumerable<Image> applyOrder(IEnumerable<Image> data, string order)
        {
            IEnumerable<Image> images;
            if (order == "asc")
            {
                images = data.OrderBy(x => x.CreatedAt);
            }
            else
            {
                images = data.OrderByDescending(x => x.CreatedAt);
            }

            return images;
        }
        
    }
}