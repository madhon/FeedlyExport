namespace FeedlyExport2
{
    internal static class Constants
    {
        public const string FeedlyUrl = @"cloud.feedly.com/v3/streams/contents?streamId=user/{0}/tag/global.saved&count=10000";
        public const string FeedlyUrlTemplate = @"http://cloud.feedly.com/v3/streams/contents?streamId=user/{userid}/tag/global.saved&count=1200";
        public const string FeedlyUserId = "677223a1-567a-457b-a95b-459b072bd850";

        public const string OAuthToken =
            "A1x5wrKJ2EWxz0iOXrnmGSwvMDDeFSYPF-VJpHkBH2vZTiwxcnSkqmu8eL_QQnAPT6PuCcCfUL546XfIuS6POxiC-PNvPilqTU-asu48E5OAIERJQtLz7ycFSVU5FG1Z4DbD4tKXGXk8dJeWGcq9oQ2r4hdM09GsLxGMDIzKc-Khu7EIk-ruh9OFvUXWKaKbNEH3uoagNVhW0iSCpbSC8jnxrdNSBw:feedlydev";

    }
}
