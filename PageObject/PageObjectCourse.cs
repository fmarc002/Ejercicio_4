using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Ejercicio_4
{
    public class PageObjectCourse : BasePageObject
    {

        public PageObjectCourse()
            : base(By.XPath(".//*[contains(@class,'course-landing-page')]"))
        { }

        public Label LblTitlePO => this.Container.NewControl<Label>(By.XPath("(.//div[@class = 'course-curriculum__container'])[1]"));

    }
}
