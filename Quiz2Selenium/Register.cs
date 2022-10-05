using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2Selenium
{

    public class Register : BasePage
    {
        By signbtn = By.XPath("//a[@href='/login']");
        By name = By.XPath("//input[@placeholder='Name']");
        By email = By.XPath("//input[@placeholder='Email Address' and @data-qa='signup-email']");
        By signupbtn = By.XPath("//button[@data-qa='signup-button']");
        By title = By.Id("id_gender1");
        By pass = By.Id("password");
        By days = By.Id("days");
        By months = By.Id("months");
        By years = By.Id("years");
        By news = By.Id("newsletter");
        By special = By.Id("optin");
        By fname = By.Id("first_name");
        By lname = By.Id("last_name");
        By compnay = By.Id("company");
        By adres = By.Id("address1");
        By count = By.Id("country");
        By state = By.Id("state");
        By city = By.Id("city");
        By zip = By.Id("zipcode");
        By phone = By.Id("mobile_number");
        By createbtn = By.XPath("//button[@data-qa='create-account']");
        By del = By.XPath("//i[@class='fa fa-trash-o']");
        By crfmdel = By.XPath("//button[text()='Delete']");

        By home = By.XPath("//i[@class='fa fa-home']");
        By accountas = By.XPath("//i[@class='fa fa-home']");
        By username = By.XPath("//i[@class='fa fa-user']");
        By delete = By.XPath("//h1[text()='Delete Account']");


        public void register(String str_name, String str_mail, String str_pass, String str_dropvalue,String str_dropvaluemo,String str_years, String firstname, String lastname, String companyname, String adress,  String county, String str_state, String citty, String zipcode, String phno)
        {
            AssertionVerify(home);
            Click(signbtn);
            AssertionVerify(signbtn);
            AssertionVerify(accountas);
            Write(name, str_name);
            Write(email, str_mail);
            Click(signupbtn);
            Click(title);
            Write(pass,str_pass);
            Click(days);
            Selectdrop(days, str_dropvalue);
            Click(days);
            Click(months);
            Selectdrop(months, str_dropvaluemo);
            Click(months);
            Click(years);
            Selectdrop(years, str_years);
            Click(years);
            Click(news);
            Click(special);
            Write(fname, firstname);
            Write(lname, lastname);
            Write(compnay, companyname);
            Write(adres, adress);
            Click(count);
            Selectdrop(count, county);
            Click(count);
            Write(state, str_state);
            Write(city, citty);
            Write(zip, zipcode);
            Write(phone, phno);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\Screenshot4.png", ScreenshotImageFormat.Png);
            Click(createbtn);
            AssertionVerify(username);
            Click(del);
            Click(crfmdel);
            AssertionVerify(delete);

        }
        
    }
}
