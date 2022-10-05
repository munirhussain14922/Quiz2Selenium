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
    public  class VerifyProduct : BasePage
    {

        By productpg = By.XPath("//a[@href='/products']");
        By addpro = By.XPath("//a[@href='/product_details/1']");
        By home = By.XPath("//i[@class='fa fa-home']");
        By productpage = By.XPath("//h2[text()='All Products']");
        By priceasert = By.XPath("//h2[text()='Blue Top']");


        public void verifypro()
        {
            AssertionVerify(home);

           
            Click(productpg);

            AssertionVerify(productpage);
            Click(addpro);
            AssertionVerify(priceasert);
        }


    }
}
