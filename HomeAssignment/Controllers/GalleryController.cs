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
        public IEnumerable<Image> Get()
        {
            var repository = new ImageRepository();
            return repository.FetchAllImage();
        }
        public IEnumerable<Image> Get(string search)
        {
            var repository = new ImageRepository();
            var images= repository.FetchAllImage();
            return images.Where(p => p.Title.Contains(search));
        }
        
    }
}