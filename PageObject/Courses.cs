using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Ejercicio_4
{
    public class Courses : BasePageObject
    {
        public Courses()
            :base(By.CssSelector(".collections-landing-page"))
        { }

        public Input SeachCourse => this.Container.NewControl<Input>(By.XPath(".//input[@name='q']"));


        public Label LblTitle => this.Container.NewControl<Label>(By.CssSelector(".products__title"));

        public Link LnkPageObject => this.Container.NewControl<Link>(By.XPath(".//h3[contains(text(),'Page Objects')]"));



    }
}
