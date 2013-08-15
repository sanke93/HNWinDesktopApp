using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HNWinDesktopApp.NewsJsonTypes;

namespace HNWinDesktopApp
{
    public class News
    {
        [JsonProperty("nextId")]
        public object NextId { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("cachedOnUTC")]
        public DateTime CachedOnUTC { get; set; }
    }

}

namespace HNWinDesktopApp.NewsJsonTypes
{
    internal class Item
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("commentCount")]
        public int CommentCount { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("postedAgo")]
        public string PostedAgo { get; set; }

        [JsonProperty("postedBy")]
        public string PostedBy { get; set; }
    }

}
