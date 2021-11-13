using System;
using System.Threading;
using OpenQA.Selenium;

namespace IC_test_5_PageObject.Pages
{
    public class HomePage
    {
        public void GotoTMPage(IWebDriver driver)
        {
        
            IWebElement adminDropDown = driver.FindElement(By.CssSelector("body > div.navbar.navbar-inverse.navbar-fixed-top > div > div > ul > li.dropdown > a"));
            adminDropDown.Click(); //Click Administriation for options


            IWebElement tAndM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tAndM.Click(); //Select Time & Materials
            Thread.Sleep(2000);
        }
    }
}
