using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;

namespace seleniumProject
{
    class SearchPage
    {
        public SearchPage()
        {
            PageFactory.InitElements(ProperContext.webDriver, this);
        }

        [FindsBy(How = How.Id, Using = "su")]
        public IWebElement btnSearch { get; set; }
        [FindsBy(How = How.Name, Using = "wd")]
        public IWebElement txtSearch { get; set; }
    }
}
