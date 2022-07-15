using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Ejercicio_4
{
    public class SeleniumJava : BasePageObject
    {
        public SeleniumJava()
            : base(By.Id("page-container"))
        { }


        //XPATH
        public Label LblTitle => this.Container.NewControl<Label>(By.XPath(".//div/h1[contains(text(),'Java')]"));

        public Label LblDescription => this.Container.NewControl<Label>(By.XPath("(.//div[@class ='et_pb_text_inner']/p)[1]"));

        public Button BtnJoinNow => this.Container.NewControl<Button>(By.XPath(".//div[contains(@class, 'mobile')]//a"));

        //video
        public Link LnkVideo => this.Container.NewControl<Link>(By.XPath(".//div//a[@class='et_pb_video_play']"));
        public Link LnkUrl => this.Container.NewControl<Link>(By.XPath(".//*[contains(@name,'fitvid0')]"));
  

        //image
        public Image ImgWebsites => this.Container.NewControl<Image>((By.XPath("(.//div/span[@class = 'et_pb_image_wrap'])[15]")));

        public Link LnkQuestion => this.Container.NewControl<Link>(By.XPath(".//div[contains(@class,'et_pb_accordion_item_0')]"));

        public Label LblQuestion =>this.Container.NewControl<Label>(By.XPath("//div[contains(@class,'et_pb_accordion_item_0')] //div[contains(@class,'et_pb_toggle_content clearfix')]"));

        public Image Color => this.Container.NewControl<Image>(By.CssSelector(".et_pb_section_0"));
        

    }
}
