namespace FeedlyExport2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Threading;
    using System.Windows.Forms;
    using FeedlyExport2.Model;
    using RestEase;

    public partial class MainForm : Form
    {
        private readonly SynchronizationContext syncContext;

        public MainForm()
        {
            InitializeComponent();
            syncContext = AsyncOperationManager.SynchronizationContext;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //IWebProxy proxy = new WebProxy("http://10.100.10.254:8080");
            //proxy.Credentials = CredentialCache.DefaultCredentials;

            //var handler = new HttpClientHandler
            //{
            //    UseDefaultCredentials = true,
            //    Proxy = proxy,
            //    UseProxy = true
            //};

            var streamId = $"user/{Constants.FeedlyUserId}/tag/global.saved";
            var streamCount = Convert.ToInt32(CountTextBox.Text);

            var feedly = RestClient.For<IFeedlyApi>("http://cloud.feedly.com/");
            feedly.Authorization = Constants.OAuthToken;

            RootObject result =
                await feedly.FetchStreamAsync(streamId, streamCount, ContinuationtextBox.Text).ConfigureAwait(false);

            //using (var sw = new StreamWriter(@"c:\temp\starred.json", false))
            //{
            //    sw.Write(JsonPrettify(apiResult.ToString()));
            //}

            syncContext.Post(x => ContinuationtextBox.Text = result.continuation, null);

            var items = result.items;
            var convertedItems = new List<SavedItem>();

            foreach (Item item in items)
            {
                var converted = new SavedItem();
                converted.Title = item.title;
                converted.Content = item.originId;
                converted.OriginUrl = item.alternate[0].href;
                convertedItems.Add(converted);
            }

            // ReSharper disable once RedundantToStringCallForValueType
            MessageBox.Show($"Item Count = {items.Count.ToString()}");

            Debugger.Break();
        }

        //private string JsonPrettify(string json)
        //{
        //    using (var sr = new StringReader(json))
        //    using (var sw = new StringWriter())
        //    {
        //        var jr = new JsonTextReader(sr);
        //        var jw = new JsonTextWriter(sw) { Formatting = Formatting.Indented };
        //        jw.WriteToken(jr);
        //        return sw.ToString();
        //    }
        //}
    }
}