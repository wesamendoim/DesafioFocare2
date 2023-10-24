using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Selenium objSelenium = new Selenium();

            ChromeDriver chromeDriver;
            IWebElement objElement_1;
            IWebElement objElement_2;
            
            chromeDriver = objSelenium.BrowserChrome();

            chromeDriver.Url = "https://www.google.com.br";

            if (chromeDriver.FindElement(By.XPath("html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/textarea")).Displayed)
            {
                chromeDriver.FindElement(By.XPath("html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/textarea")).SendKeys("RPA");

                chromeDriver.FindElement(By.XPath("html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/textarea")).SendKeys(OpenQA.Selenium.Keys.Enter);

                objElement_1 = chromeDriver.FindElement(By.XPath("//*[@id='Odp5De']/div/div[1]/div/div[1]/block-component/div/div[1]/div/div/div/div/div[1]/div/div/div/div/div[2]/div/div/div[1]/div/span/a/h3"));
                
                objElement_2 = chromeDriver.FindElement(By.XPath("//*[@id='rso']/div[2]/div/div/div[1]/div/div/span/a/h3"));
                
                Console.WriteLine(objElement_1.Text);
               
                Console.WriteLine(objElement_2.Text);

                Console.ReadLine();
                chromeDriver.Quit();

            }
            else
            {
                Console.WriteLine("Elemento não disponivel para o andamento do robô");
                
            }

        }
    }
}
