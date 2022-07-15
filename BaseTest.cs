using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Ejercicio_4
{
    public class BaseTest : IDisposable
    {

        public BaseTest()
        {

        }

        protected IWebDriver Driver
        {
            get
            {
                return DriverProvider.Driver;
            }
        }

        protected void GoToUrl(string url)
        {
            this.Driver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            DriverProvider.DestroyDriver();
        }


    }
}
