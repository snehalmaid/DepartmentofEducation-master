using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NationalParks.Models

{

    public class School
    {
        public string name { get; set; }
        public string size { get; set; }
        public string id { get; set; }
    }


    public class Schools
    {
        public string total { get; set; }
        public List<School> data { get; set; }
        public string page { get; set; }
        public string per_page { get; set; }
    }

}
