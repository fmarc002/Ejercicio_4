using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Ejercicio_4
{
    public class Automation : BasePageObject
    {
        public Automation()
            : base(By.Id("et-boc"))
        { }

        public Link LnkSeleniumJava => this.Container.NewControl<Link>(By.LinkText("Selenium Java"));

        public Link LnkCourse => this.Container.NewControl<Link>(By.LinkText("Courses"));

        public Link LnkInteraction => this.Container.NewControl<Link>(By.XPath("//a[contains(text(),'Interactions')]"));
    }
}
