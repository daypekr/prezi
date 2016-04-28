using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using Newtonsoft.Json;

namespace HomeAssignment.Models
{
    public class ImageRepository
    {
        public List<Image> FetchAllImage()
        {
            var dataPath = HostingEnvironment.MapPath(@"~/App_Data/prezis.json");

            var dataText = File.ReadAllText(dataPath);

            var images = JsonConvert.DeserializeObject<List<Image>>(dataText);

            return images;
        } 
    }
}