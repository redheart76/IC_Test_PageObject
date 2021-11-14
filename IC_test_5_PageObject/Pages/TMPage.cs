using System;
using System.Threading;
using IC_test_5_PageObject.Utilities;
using OpenQA.Selenium;

namespace IC_test_5_PageObject.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            IWebElement createBTN = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createBTN.Click(); //Click create new button

            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click(); //Select type code option

            IWebElement timeOpt = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOpt.Click(); // Select time option

            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("Vic"); //Input new code

            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("1129");//Input description

            IWebElement unitPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            unitPrice.Click();
            IWebElement price = driver.FindElement(By.Id("Price"));
            price.SendKeys("18"); //Input price

            IWebElement saveBTN = driver.FindElement(By.Id("SaveButton"));
            saveBTN.Click();//Save new 
            Wait.WaitToBeVisible(driver, "Xpath", "//*[@id='container']/p/a", 2);
        }
        public void EditTm(IWebDriver driver)
        {
            IWebElement editBTN = driver.FindElement(By.CssSelector("#tmsGrid > div.k-grid-content > table > tbody > tr:nth-child(1) > td:nth-child(5) > a.k-button.k-button-icontext.k-grid-Edit"));
            editBTN.Click(); // Click the edit button to edit the item


            IWebElement code = driver.FindElement(By.Id("Code"));
            code.Click();
            code.Clear();
            code.SendKeys("Oxf"); //Change to a new code

            IWebElement saveBTN = driver.FindElement(By.Id("SaveButton"));
            saveBTN.Click();//Save chages
            Thread.Sleep(2000);

            IWebElement oxf = driver.FindElement(By.CssSelector("#tmsGrid > div.k-grid-content > table > tbody > tr:nth-child(1) > td:nth-child(1)"));

            if (oxf.Text == "Oxf")
            {
                Console.WriteLine("The change has been saved,test passed");
            }
            else
            {
                Console.WriteLine("The change has not been saved, test failed"); //Check if the new item has been saved successfully
            }
        }


        public void DeleteTM(IWebDriver driver)
        {
            IWebElement delBTN = driver.FindElement(By.CssSelector("#tmsGrid > div.k-grid-content > table > tbody > tr:nth-child(1) > td:nth-child(5) > a.k-button.k-button-icontext.k-grid-Delete"));
            delBTN.Click(); // Click the delete button to delete the item

            IAlert alart = driver.SwitchTo().Alert();
            alart.Accept(); //Click ok to confirm the deletion
        }
    }
}
