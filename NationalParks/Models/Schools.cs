using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalParks.Models

{

    public class School
    {
        public string name { get; set; }
        public int size { get; set; }
        public int id { get; set; }
    }


    public class Schools
    {
        public string total { get; set; }
        public List<School> data { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
    }

}
