using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation
{
    class Program
    {
        static string url = "http://www.aiub.edu/";
        static IWebDriver driver = new ChromeDriver();
        static string actualtitle = "Home | American International University-Bangladesh (AIUB)";
        static void Main(string[] args)
        {
            if (TC_01_CheckLoadingofThePage())
            {
                Console.WriteLine("TC_01_CheckLoadingofThePage: Passed");
            }

            else
                Console.WriteLine("TC_01_CheckLoadingofThePage: Failed");
            if (TC_02())
            {
                Console.WriteLine("TC_02: Passed");
            }

            else
                Console.WriteLine("TC_02: Failed");
        }

            static public bool TC_01_CheckLoadingofThePage()
        {
            driver.Navigate().GoToUrl(url);
            string windowTitle = driver.Title;

            if(actualtitle==windowTitle)
            {
               return true;
            }

            else
                return false;

        }

        static public bool TC_02()
        {
            if (TC_01_CheckLoadingofThePage())
            {
                IWebElement campus = driver.FindElement(By.ClassName("img-responsive"));
                campus.Click();

                string campusPageTitle = driver.FindElement(By.ClassName("header-title")).Text;

                if (campusPageTitle == "AIUB CAMPUS")
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
