using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadingAPI.Models
{

    public class Rootobject
    {
        public Movie[] Property1 { get; set; }
    }

    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public float runtime { get; set; }
    }

}
