using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoogleSearchParser.Core.Google
{
    public class GoogleParser : IParser<List<string>>
    {
        public event Func<bool> OnCaptchaContinue;

        public List<string> Parse(string url, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(url);

            while (driver.FindElements(By.XPath("//div[@id='recaptcha']")).Count > 0)
            {
                if (OnCaptchaContinue == null || OnCaptchaContinue?.Invoke() == false)
                    return null;
            }

            var urls = driver
                .FindElements(By.XPath("//div[@class='srg']//div[@class='r']/a[@href and not(@class)]"))                
                .Select(element => element.GetAttribute("href"))
                .ToList();

            return urls.Count > 0 ? urls : null;
        }
    }
}
