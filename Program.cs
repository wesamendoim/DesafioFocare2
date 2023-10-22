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
            IWebElement objELement_3;

            chromeDriver = objSelenium.BrowserChrome();
            
            chromeDriver.Url = "https://www.google.com.br";

            if (chromeDriver.FindElement(By.XPath("html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/textarea")).Displayed)
            {
                chromeDriver.FindElement(By.XPath("html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/textarea")).SendKeys("RPA");

                ///html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]
                chromeDriver.FindElement(By.XPath("html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/textarea")).SendKeys(OpenQA.Selenium.Keys.Enter);

                objElement_1 = chromeDriver.FindElement(By.XPath("//*[@id='tads']/div/div/div/div/div[1]/a/div[1]/span"));
                //*[@id="tads"]/div/div/div/div/div[2]/a/div[1]/span

                objElement_2 = chromeDriver.FindElement(By.XPath("//*[@id='rso']/div[2]/div/div/div[1]/div/div/span/a/h3"));

                Console.WriteLine(objElement_1.Text);

                Console.WriteLine(objElement_2.Text);

                //Elemento para realizar um loop e achar os valores
                //objELement_3 = chromeDriver.FindElement(By.XPath("html/body/div[5]/div"));

                chromeDriver.Quit();

            }
            else
            {
                Console.WriteLine("Elemento não disponivel para o andamento do robô");
                
            }

        }
    }
}
