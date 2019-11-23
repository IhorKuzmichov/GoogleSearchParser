using OpenQA.Selenium;

namespace GoogleSearchParser.Core
{
    interface IParser<T> where T : class
    {
        T Parse(string url, IWebDriver driver);
    }
}
