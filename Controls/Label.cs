using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Ejercicio_4
{
    public class Label : BaseControl
    {
        public Label()
        {

        }

        public Label(By locator)
            : base(locator)
        { }

        public string Text => this.WebElement.Text;
        

    }
}
