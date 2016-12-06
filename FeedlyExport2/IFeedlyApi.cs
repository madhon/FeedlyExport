namespace FeedlyExport2
{
    using System.Threading.Tasks;
    using FeedlyExport2.Model;
    using RestEase;

    public interface IFeedlyApi
    {
        [Header("Authorization")]
        string Authorization { get; set; }
        
        [Get("v3/streams/contents")]
        Task<RootObject> FetchStreamAsync(string streamId, int count, string continuation = "");
    }
}
