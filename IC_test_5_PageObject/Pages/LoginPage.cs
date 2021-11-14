using System;
using IC_test_5_PageObject.Utilities;
using OpenQA.Selenium;

namespace IC_test_5_PageObject
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            driver.Url = "http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f"; //Launch Turnup

            Wait.WaitToBeClickable(driver, "Id", "UserName", 2); 

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari"); //Input valid username

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123"); //Input valid password

            IWebElement LoginBTN = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginBTN.Click();//Click login button to log in
        }
    }
}
