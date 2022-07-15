using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Ejercicio_4
{
    public class ClickableControl : BaseControl
    {

        public ClickableControl()
        {

        }

        public ClickableControl(By locator)
            : base(locator)
        { }

        public void Click()
        {
            this.WebElement.Click();
        }
    }
}
