using System;
using IC_test_5_PageObject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IC_test_5_PageObject
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(); //Open Chrome
    

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver); //Login page object initializaiton and defination

            HomePage homePageObj = new HomePage();
            homePageObj.GotoTMPage(driver);//Home page object initialization and defination

            TMPage tmPageObj = new TMPage();
           // tmPageObj.CreateTM(driver); //TM page object initializaiton and defination
            tmPageObj.EditTm(driver);// Edit TM
            //tmPageObj.DeleteTM(driver); //Delete TM
        }
    }
}
