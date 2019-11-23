namespace GoogleSearchParser.Core.Google
{
    public static class Extensions
    {
        public static string ToUrlFormat(this UrlsUpdateDate updateDate)
        {
            switch (updateDate)
            {
                case UrlsUpdateDate.Last24Hours: return "tbs=qdr:d";
                case UrlsUpdateDate.LastWeek: return "tbs=qdr:w";
                case UrlsUpdateDate.LastMonth: return "tbs=qdr:m";
                case UrlsUpdateDate.LastYear: return "tbs=qdr:y";
                default: return "";
            }
        }
    }
}
