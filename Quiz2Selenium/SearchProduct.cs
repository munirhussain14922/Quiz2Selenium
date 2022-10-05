using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2Selenium
{
    public class SearchProduct : BasePage
    {
        By productpg = By.XPath("//a[@href='/products']");
        By searchinput = By.Id("search_product");
        By saerchbtn = By.Id("submit_search");
        By home = By.XPath("//i[@class='fa fa-home']");
        By prodvei = By.XPath("//h2[text()='All Products']");
        By saerassert = By.XPath("(//h2[text()='Rs. 400'])[1]");
        public void Searchpage(String searc)
        {

            AssertionVerify(home);
            Click(productpg);
           AssertionVerify(prodvei);

            Write(searchinput, searc);
            Click(saerchbtn);

            AssertionVerify(saerassert);
           

        }
    }
}
