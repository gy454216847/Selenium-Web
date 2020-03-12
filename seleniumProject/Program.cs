using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace seleniumProject
{
    class Program
    {
        //create the reference of Chrome
        //IWebDriver webDriver = new ChromeDriver();
        
        [SetUp]
        public void Initialize()
        {
            ProperContext.webDriver = new ChromeDriver();
            //Navigate to baidu
            ProperContext.webDriver.Url="http://www.baidu.com";
            Console.WriteLine("Open Website");
        }
        [Test]
        public void FirstTest()
        {
            //Find element
            //IWebElement textSerach = webDriver.FindElement(By.Id("kw"));
            //IWebElement btnSearch = webDriver.FindElement(By.Id("su"));

            //Input value
            //textSerach.SendKeys("test");
            //CustomMethod.EnterText(driver,"Name", "wd", "test");
            ////CustomMethod.EnterText("Name", "wd", "test");
            //CustomMethod.EnterText( ElementType.Name, "wd", "test");
            //click search
            //btnSearch.Click();
            //CustomMethod.Click(driver,"id", "su");
            //CustomMethod.Click("id", "su");
            //CustomMethod.CLIck( ElementType.id, "su");
            SearchPage SP = new SearchPage();
            SP.txtSearch.SendKeys("test");
            SP.btnSearch.Click();
            //wait time
            Thread.Sleep(2000);

            Console.WriteLine("Execute Test");
        }
        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
            ProperContext.webDriver.Close();
            Console.WriteLine("Close ");
        }
    }
}
