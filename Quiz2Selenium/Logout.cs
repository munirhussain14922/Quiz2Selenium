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
    public class Logout : BasePage
    {
        By signbtn = By.XPath("//a[@href='/login']");
        By email = By.XPath("//input[@data-qa='login-email']");
        By pass = By.XPath("//input[@placeholder='Password']");
        By submit = By.XPath("//button[@data-qa='login-button']");
        By logoutbnt = By.XPath("//a[@href='/logout']");
        By home = By.XPath("//i[@class='fa fa-home']");
        By accountas = By.XPath("//i[@class='fa fa-home']");
        By username = By.XPath("//i[@class='fa fa-user']");
        By logpage = By.XPath("//h2[text()='Login to your account']");

        public void logout(String mail, String passw)
        {
            AssertionVerify(home);
            Click(signbtn);
            Write(email, mail);
            Write(pass, passw);
            Click(submit);
            AssertionVerify(username);
            Click(logoutbnt);
            Thread.Sleep(2000);
            AssertionVerify(logpage);

        }
    }
}
