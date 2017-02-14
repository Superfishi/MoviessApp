using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixRouletteApp.Models
{
    public class Movie
    {
        [JsonProperty("show_title")]
        public string Title { get; set; }

        [JsonProperty("release_year")]
        public string ReleaseYear { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("poster")]
        public string Poster { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
        
    }
}
