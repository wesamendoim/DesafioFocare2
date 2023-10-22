using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    public class Selenium
    {
        public void BrowserChrome(string url)
        public ChromeDriver BrowserChrome()
        {
            ChromeDriver objChrome = new ChromeDriver();

            objChrome.Url = url;

            return objChrome;

        }

    }
}
