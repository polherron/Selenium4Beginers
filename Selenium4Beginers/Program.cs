using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace Selenium4Beginers
{
    class Program
    {
        public static void Main()
        {
            IWebDriver driver = new ChromeDriver(@"c:\libraries\");
            driver.Url = "http://www.google.com";

        }
    }
}

