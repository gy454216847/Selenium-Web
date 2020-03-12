using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumProject
{
    enum  ElementType
    {
        id,
        Name,
        XPath,
        CssSelector,
        Class,
        ClassName,
        LinkText

    }
    class ProperContext
    {
        
        public static IWebDriver webDriver { get; set; }
    }
}
