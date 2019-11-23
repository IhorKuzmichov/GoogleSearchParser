using System;
using System.Linq;

namespace GoogleSearchParser.Core.Google
{
    public class GoogleSettings : IParserSettings
    {
        public string[] QueryWords { get; set; }
        public UrlsUpdateDate UpdateDate { get; set; }
        public int StartPoint { get; set; }
        public int UrlsCountAtATime { get; set; }        

        public GoogleSettings(string[] queryWords, UrlsUpdateDate updateDate, int startPoint = 1, int urlsCountAtATime = 100)
        {
            QueryWords = queryWords;
            UpdateDate = updateDate;
            StartPoint = startPoint;
            UrlsCountAtATime = urlsCountAtATime;
        }

        public string BuildUrl(int id)
        {
            return $"https://www.google.com/search?" +
                $"q={string.Join("+", QueryWords.Select(word => word = Uri.EscapeDataString(word)))}" +
                $"&{UpdateDate.ToUrlFormat()}" +
                $"&start={id}" +
                $"&num={UrlsCountAtATime}";
        }
    }
}
