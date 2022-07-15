using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Ejercicio_4
{
    public class Link : ClickableControl
    {
        public Link()
        {

        }

        public Link(By locator)
            : base(locator)
        { }

        public string Text => this.WebElement.Text;

    }
}