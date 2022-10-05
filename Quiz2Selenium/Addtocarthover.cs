using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Quiz2Selenium
{
    public class Addtocarthover: BasePage
    {
       /By home = By.XPath("//i[@class='fa fa-home']");
        By productpg = By.XPath("//a[@href='/products']");
   

        By ct = By.XPath("(//a[@data-product-id='2'])[1]");
        By hover = By.CssSelector("body > section:nth-child(3) > div > div > div.col-sm-9.padding-right > div.features_items > div:nth-child(3) > div > div.single-products > div.product-overlay");
        By conti = By.XPath("//button[text()='Continue Shopping']");
       


        public void Hoveraddtocart()
        {



           
           AssertionVerify(home);
            Click(productpg);
         
            hoverhandle(hover);
            Thread.Sleep(1000);
            
            Click(ct);
            Click(conti);
           
       


        }
    }
}
