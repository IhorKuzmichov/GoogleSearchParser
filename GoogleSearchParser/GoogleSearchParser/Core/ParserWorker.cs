using OpenQA.Selenium;
using System;
using System.Threading.Tasks;

namespace GoogleSearchParser.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        IWebDriver driver;

        bool isActive;

        #region Properties

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        public event Action<object, T, string> OnNewData;
        public event Action<object> OnCompleted;

        public ParserWorker(IParser<T> parser, IWebDriver driver)
        {
            this.parser = parser;
            this.driver = driver;
        }

        public ParserWorker(IParser<T> parser, IWebDriver driver, IParserSettings parserSettings) : this(parser, driver)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            for (int i = parserSettings.StartPoint; ; i += parserSettings.UrlsCountAtATime)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                T result = null;
                    
                await Task.Run(() => result = parser.Parse(parserSettings.BuildUrl(i), driver));

                if (result == null)
                {
                    break;
                }

                OnNewData?.Invoke(this, result, parserSettings.BuildUrl(i));
            }

            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
