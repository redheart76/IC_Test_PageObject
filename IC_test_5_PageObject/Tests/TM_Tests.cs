 using System;
using IC_test_5_PageObject.Pages;
using IC_test_5_PageObject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace IC_test_5_PageObject
{
    [TestFixture]

    class TM_Tests : CommonDriver
    {
        //static void Main(string[] args)
        // {
        //IWebDriver driver = new ChromeDriver(); //Open Chrome


        // LoginPage loginPageObj = new LoginPage();
        //loginPageObj.LoginSteps(driver); //Login page object initializaiton and defination

        // HomePage homePageObj = new HomePage();
        //homePageObj.GotoTMPage(driver);//Home page object initialization and defination

        // TMPage tmPageObj = new TMPage();
        // tmPageObj.CreateTM(driver); //TM page object initializaiton and defination
        //tmPageObj.EditTm(driver);// Edit TM
        //tmPageObj.DeleteTM(driver); //Delete TM

        // }

        [SetUp]

        public void LoginAction()
        {
            
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver); //Login page object initializaiton and defination

            HomePage homePageObj = new HomePage();
            homePageObj.GotoTMPage(driver);//Home page object initialization and defination

        }
        [Test]
        public void CreateTMTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver); //TM page object initializaiton and defination
        }
        [Test]
        public void EditTMTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTm(driver);// Edit TM
        }
        [Test]
        public void DeletTMTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver); //Delete TM
        }

        [TearDown]
        public void closeTest()
        {

            driver.Close();
        }
    }
}