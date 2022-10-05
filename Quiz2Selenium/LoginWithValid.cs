using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2Selenium
{
    public class LoginWithValid : BasePage
    {
        By signbtn = By.XPath("//a[@href='/login']");
        By email = By.XPath("//input[@data-qa='login-email']");
        By pass = By.XPath("//input[@placeholder='Password']");
        By submit = By.XPath("//button[@data-qa='login-button']");
        By del = By.XPath("//i[@class='fa fa-trash-o']");
        By crfmdel = By.XPath("//button[text()='Delete']");
        By home = By.XPath("//i[@class='fa fa-home']");
        By accountas = By.XPath("//i[@class='fa fa-home']");
        By username = By.XPath("//i[@class='fa fa-user']");
        By delete = By.XPath("//h1[text()='Delete Account']");



        public void ValidLogin(String mail, String passw)
        {
            AssertionVerify(home);
            Click(signbtn);
            AssertionVerify(accountas);
            Write(email, mail);
            Write(pass, passw);
            Click(submit);
            AssertionVerify(username);
            Click(del);
            Click(crfmdel);
            AssertionVerify(delete);
      
        }
    }
}
