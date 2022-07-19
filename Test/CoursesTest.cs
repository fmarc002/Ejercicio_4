using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Xunit;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace Ejercicio_4
{
    //aplicamos herencia
    public class CoursesTest : BaseTest
    {

        //Punto 4 - Agregar otra clase test: Agregar otra clase de test para otra sección diferente
        //de la utilizada en el ejercicio anterior e implementar 2 tests en esa clase:
        //1. Uno que verifique el contenido propio.
        //2. Otro que haga alguna acción permitida en la página y se verifiquen los resultados de
        //esa acción.

        private const String ultimateQa = "https://www.ultimateqa.com/automation/";

        public CoursesTest()
        {

        }

        [Fact]
        public void test_1()
        {
            this.GoToUrl(ultimateQa);
            var automation = new Automation();
            automation.LnkCourse.Click();

            Courses courses = new Courses();
            Assert.True(courses.HasLoaded());


            courses.SeachCourse.Clear();
            Assert.Empty(courses.SeachCourse.Text);

            courses.SeachCourse.Write("Selenium");
            courses.SeachCourse.Write(Keys.Enter);

            //courses.SeachCourse.Write("Selenium" + Keys.Enter);
            //courses.SeachCourse.Write($"Selenium{Keys.Enter}");

            Assert.Contains("Selenium",courses.LblTitle.Text);

            Assert.True(courses.LnkPageObject.Displayed);

            courses.LnkPageObject.Click();
            PageObjectCourse pageObject = new  PageObjectCourse();
            Assert.True(pageObject.HasLoaded());

            // Punto 7:
            // Extender Webdriver: Extender Webdriver para que se haga un explicit wait del
            // elemento cada vez que se lo busca.Ver ejemplo de cómo se hace en el proyecto
            // ejemplo de git.
            pageObject.LblTitlePO.WaitUntilVisible(TimeSpan.FromSeconds(3));

            //declarás el tipo de elemento del selector en este caso  es tipo "string"
            string titleText = pageObject.LblTitlePO.Text; 
            var start_title = titleText.Trim().StartsWith("Course"); //TrimStart y TrimEnd
            Assert.True(start_title);

        }

        // test with Select Element
        [Fact]
        public void test_2()
        {
            this.GoToUrl(ultimateQa);
            var automation = new Automation();
            automation.LnkInteraction.Click();
           
            Interactions interactions = new Interactions();
            Assert.True(interactions.HasLoaded());
           
            ////select element
            ////list select element
            var expectedOptions = new List<string>()
            {
                "Volvo", "Saab", "Opel", "Audi"
            };

            foreach (var opt in expectedOptions)
            {
                Assert.Contains(opt,interactions.DropSelect.Options());
            }

            Assert.Equal("Volvo", interactions.DropSelect.SelectedOption());
            interactions.DropSelect.SelectText("Audi");
            Assert.Equal("Audi", interactions.DropSelect.SelectedOption());
            interactions.DropSelect.SelectValue("saab");
            Assert.Equal("Saab",interactions.DropSelect.SelectedOption());
            interactions.DropSelect.SelectByIndex(0);
            Assert.Equal("Volvo", interactions.DropSelect.SelectedOption());

        }

    }
}
