using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Ejercicio_4
{
    public class BaseControl
    {
        protected By locator;
        protected IWebElement source;
        private IWebDriver driver;
        protected Actions Actions => new Actions(this.driver);

        public BaseControl(By locator)
        {
            this.locator = locator;
            this.source = null;
            this.driver = DriverProvider.Driver;
        }

        public BaseControl(IWebElement source)
        {
            this.locator = null;
            this.source = source;
            this.driver = DriverProvider.Driver;
        }

        public BaseControl()
        {
            this.locator = null;
            this.source = null;
            this.driver = DriverProvider.Driver;
        }

        public void SetLocator(By locator)
        {

            this.locator = locator;
        }

        public void SetSource(IWebElement source)
        {
            this.source = source;
        }

        protected IWebElement WebElement
        {
            get
            {
                try
                {
                    if (this.locator is not null)
                    {
                        this.source = this.driver.FindElement(this.locator);
                    }
                    return this.source;
                }
                catch
                {
                    return null;
                }
            }
        }

        public bool Displayed
        {
            get
            {
                try
                {
                    return this.WebElement.Displayed;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Enabled
        {
            get
            {
                try
                {
                    return this.WebElement.Enabled;
                }
                catch
                {
                    return false;
                }
            }
        }


        //public void ScrollIntoView()
        //{
        //    var script = "arguments[0].focus();";
        //    var js = (IJavaScriptExecutor)driver;

        //    if (!this.IsCurrentlyVisible)
        //    {
        //        this.WebElement.ScrollIntoView(true);
        //    }

        //    js.ExecuteScript(script, this.WebElement);
        //}


        public string GetAttributeOrEmpty(string attributeName)
        {
            return this.WebElement.GetAttributeOrEmpty(attributeName);
        }


        public string GetCssValueOrEmpty(string cssValue)
        {
            return this.WebElement.GetCssValue(cssValue);
        }


        public bool WaitUntilVisible(TimeSpan timeout)
        {
            return this.driver.ExplicitWaitUntil(() => this.Displayed, timeout);
        }

    }
}
