using JAQ_BackendDev.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAQ_BackendDev.API.Models
{
    public class Quiz_DTO
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string Difficulty { get; set; }

        [JsonProperty("questions", NullValueHandling = NullValueHandling.Ignore)]
        //nav prop
        public List<Question_DTO> questions { get; set; }

    }
}
