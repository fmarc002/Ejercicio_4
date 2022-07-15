using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Ejercicio_4
{
    public class DriverProvider
    {
        private static IWebDriver driver;
        // protected ChromeOptions options;

        public static IWebDriver Driver
        {
            get
            {
                if (driver is null)
                {
                    InitializeDriver();
                }
                return driver;
            }

        }

        private static void InitializeDriver()
        {
            //options = new ChromeOptions();
            //driver = new ChromeDriver(options);

            var defaultTimeout = TimeSpan.FromSeconds(10);
            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService());
            driver.Manage().Timeouts().PageLoad = defaultTimeout;
            driver.Manage().Timeouts().AsynchronousJavaScript = defaultTimeout;
            //cada vez que busca un elemento espera 10seg
            driver.Manage().Timeouts().ImplicitWait = defaultTimeout;
            driver.Manage().Window.Maximize();

        }


        public static void DestroyDriver()
        {
            try
            {
                driver.Close();
                driver.Quit();
            }
            catch
            {
                driver = null;
            }

        }


    }
}
