namespace GoogleSearchParser.Core
{
    interface IParserSettings
    {
        string[] QueryWords { get; set; }
        UrlsUpdateDate UpdateDate { get; set; }
        int StartPoint { get; set; }
        int UrlsCountAtATime { get; set; }

        string BuildUrl(int id);
    }
}
