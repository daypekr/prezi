using System;

namespace HomeAssignment.Models
{
    // Model class for holding information of each item in the sample data
    
    public class Image
    {
        //"id": "56f137f4d62116d1231786ca",
        //"title": "Lorem commodo excepteur minim",
        //"thumbnail": "https://placeimg.com/400/400/any",
        //"creator": {
        //   "name": "cupidatat excepteur",
        //   "profileUrl": "http://randomprofile.prezi.com/"
        //   },
        //"createdAt": "July 31, 2015"
        public string Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public Creator Creator { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}