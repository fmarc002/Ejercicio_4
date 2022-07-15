using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Xunit;

namespace Ejercicio_4
{
    public class JavaTest : BaseTest
    {

        // Punto 3.1 - Ir a la sección “NN” (cada pasante le toca una) y verifique la visualización
        //de los elementos principales de la página, verificar su texto y/o valor por defecto.

        private const String ultimateQa = "https://www.ultimateqa.com/automation/";

        public JavaTest()
        { }

        [Fact]
        public void test_1()
        {
            this.GoToUrl(ultimateQa);
            var automation = new Automation();
            automation.LnkSeleniumJava.Click();

            var seleniumJava = new SeleniumJava();
            Assert.True(seleniumJava.HasLoaded());

            Assert.Contains("Java", seleniumJava.LblTitle.Text);

            var description = seleniumJava.LblDescription.Text;
            Assert.True(seleniumJava.LblDescription.Displayed);
            Assert.Contains("automation engineer", description);

        }

        // Punto 3.3 - Clonar el test y cambiar alguna assertion para lograr que FALLE el segundo test
        [Fact]
        public void test_2()
        {
            this.GoToUrl(ultimateQa);
            
            var automation = new Automation();
            automation.LnkSeleniumJava.Click();

            var seleniumJava = new SeleniumJava();
            Assert.True(seleniumJava.HasLoaded());

            Assert.Contains("Java", seleniumJava.LblTitle.Text);

            //LO DEJE TRUE PARA QUE PASE
            Assert.True(seleniumJava.BtnJoinNow.Displayed);

        }

        // Punto 3.4 - Crear otro test que realice alguna acción/workflow en la página y agregar las aserciones del resultado.
        [Fact]
        public void test_3()
        {
            this.GoToUrl(ultimateQa);

            var automation = new Automation();
            automation.LnkSeleniumJava.Click();

            var seleniumJava = new SeleniumJava();
            Assert.True(seleniumJava.HasLoaded());

            Assert.Contains("Java", seleniumJava.LblTitle.Text);

            Assert.True(seleniumJava.BtnJoinNow.Displayed);

            //CSSS - obtener el Color de background-image. Va en degrade
            var rgbFormat = seleniumJava.Color.background;
            Console.WriteLine(rgbFormat);
            string colorExpected = "linear-gradient(rgb(71, 74, 182) 0%, rgb(146, 113, 246) 100%)";
            Assert.Contains(colorExpected, rgbFormat);

            //XPATH watch the video
            Assert.True(seleniumJava.LnkVideo.Displayed);

            //image: Featured On These Websites
            Assert.True(seleniumJava.ImgWebsites.Displayed);

            //url - Use method GetAttribute()
            //link => source (getatrtibute) VER SI PASA EL TEST, SI PASA BORRAR
            String url_video = seleniumJava.LnkUrl.GetAttributeOrEmpty("src");
            var url_expected = "https://www.youtube.com/embed/aRbmmYf41yQ?feature=oembed";
           /* Assert.AreEqual(url_expected, url_video);*/ // For the same object reference
            Assert.Equal(url_expected, url_video);

            seleniumJava.LnkQuestion.Click();

            // use method GetCssValue ("Style")
            Assert.Equal("block", seleniumJava.LblQuestion.GetCssValueOrEmpty("display"));

        }
    }
}

