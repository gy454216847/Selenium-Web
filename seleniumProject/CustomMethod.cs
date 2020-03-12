using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumProject
{
    class CustomMethod
    {
        //EnterText
        //public static void EnterText(IWebDriver driver,string elementType, string element, string value)
        public static void EnterText(ElementType elementType, string element, string value)
        {
            //if(elementType == "id")
            if (elementType == ElementType.id)
            {
                //driver.FindElement(By.Id(element).SendKeys(value);
                ProperContext.webDriver.FindElement(By.Id(element)).SendKeys(value);
            }

            //if(elementType == "Name")
            if (elementType == ElementType.Name)
            {

                //driver.FindElement(By.Name(element).SendKeys(value);
                ProperContext.webDriver.FindElement(By.Name(element)).SendKeys(value);
            }
            
        }

        //ClickButton
        //public static void EnterText(IWebDriver driver,string elementType, string element, string value)
        public static void CLIck(ElementType elementType, string element)
        {
            //if(elementType == "id")
            if (elementType == ElementType.id)
            {
                //driver.FindElement(By.Id(element).SendKeys(value);
                ProperContext.webDriver.FindElement(By.Id(element)).Click();
            }
            //if(elementType == "Name")
            if (elementType == ElementType.Name)
            {
                //driver.FindElement(By.Name(element).SendKeys(value);
                ProperContext.webDriver.FindElement(By.Name(element)).Click();
            }
        }
    }
}
