// ReSharper disable InconsistentNaming
namespace FeedlyExport2.Model
{
    using System.Collections.Generic;

    public class Origin
    {
        public string htmlUrl { get; set; }
        public string streamId { get; set; }
        public string title { get; set; }
    }

    public class Alternate
    {
        public string type { get; set; }
        public string href { get; set; }
    }

    public class Summary
    {
        public string content { get; set; }
        public string direction { get; set; }
    }

    public class Tag
    {
        public string id { get; set; }
        public string label { get; set; }
    }

    public class Content
    {
        public string content { get; set; }
        public string direction { get; set; }
    }

    public class Visual
    {
        public string url { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public string processor { get; set; }
        public string contentType { get; set; }
    }

    public class Canonical
    {
        public string href { get; set; }
        public string type { get; set; }
    }

    public class Thumbnail
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Enclosure
    {
        public string href { get; set; }
        public string type { get; set; }
        public int? length { get; set; }
    }

    public class Webfeeds
    {
        public string logo { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public List<string> keywords { get; set; }
        public string originId { get; set; }
        public string fingerprint { get; set; }
        public Origin origin { get; set; }
        public string title { get; set; }
        public object published { get; set; }
        public object crawled { get; set; }
        public List<Alternate> alternate { get; set; }
        public string author { get; set; }
        public Summary summary { get; set; }
        public bool unread { get; set; }
        public List<Tag> tags { get; set; }
        public object actionTimestamp { get; set; }
        public Content content { get; set; }
        public long? updated { get; set; }
        public string canonicalUrl { get; set; }
        public string ampUrl { get; set; }
        public string cdnAmpUrl { get; set; }
        public Visual visual { get; set; }
        public int? engagement { get; set; }
        public double? engagementRate { get; set; }
        public long? recrawled { get; set; }
        public List<Canonical> canonical { get; set; }
        public List<Thumbnail> thumbnail { get; set; }
        public List<Enclosure> enclosure { get; set; }
        public Webfeeds webfeeds { get; set; }
    }

    public class RootObject
    {
        public string id { get; set; }
        public string continuation { get; set; }
        public List<Item> items { get; set; }
    }
}
