using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumfirstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a refernce to browser
            IWebDriver driver = new ChromeDriver();

            //now navigate the page that u want to open
            driver.Navigate().GoToUrl("http://www.google.com");

            //find the element the open url 
            IWebElement element = driver.FindElement(By.Name("q"));

            //the action u want to perform on it 
            //perform operations

            element.SendKeys("guru99");

            //for closing the opened window which was opened by chrome
            driver.Close();


        }
    }
}
