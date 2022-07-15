using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Ejercicio_4
{
    public static class WebDriverExtensions
    {
        //private static IWebDriver Driver => WebDriverInstanceManager.Instance.CurrentDriver;

        // Punto 7:
        // Extender Webdriver: Extender Webdriver para que se haga un explicit wait del
        // elemento cada vez que se lo busca.Ver ejemplo de cómo se hace en el proyecto
        // ejemplo de git.

        public static bool ExplicitWaitUntil(this IWebDriver driver, Func<bool> func, TimeSpan timeout)
        {

            try
            {
                return new WebDriverWait(driver, timeout).Until(x => func());

            }

            catch
            {

                return false;

            }

        }

        public static string GetAttributeOrEmpty(this IWebElement element, string attributeName)
        {
            try
            {
                string result = element?.GetAttribute(attributeName) ?? string.Empty;
                return result;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GetCssValueOrEmpty(this IWebElement element, string cssValue)
        {
            try
            {
                string result = element?.GetCssValue(cssValue) ?? string.Empty;
                return result;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
