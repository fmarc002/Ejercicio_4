using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Ejercicio_4
{
    public class Interactions :BasePageObject
    {
        public Interactions()
            : base(By.XPath(".//*[contains(@class,'page-template-default page page-id-909')]"))
        { }

        public SelectElement DropSelect => new SelectElement(this.Container.FindElement(By.CssSelector(".et_pb_blurb_description select")));


    }
}
