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
    public class Downloadinvice : BasePage
    {
        By addpro = By.XPath("//a[@href='/product_details/1']");
        By addcartt = By.XPath("(//i[@class='fa fa-shopping-cart'])[2]");
        By viewcart = By.XPath("(//a[@href='/view_cart'])[2]");
        By procedcheck = By.XPath("//a[text()='Proceed To Checkout']");
        By loginbt = By.XPath("(//a[@href='/login'])[2]");
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
        By contin = By.XPath("//a[@data-qa='continue-button']");
        By cartbtn = By.CssSelector("#header > div > div > div > div.col-sm-8 > div > ul > li:nth-child(3) > a");
        By peoced = By.XPath("//a[text()='Proceed To Checkout']");
        By textarea = By.XPath("//textarea[@class='form-control']");
        By placed = By.XPath("//a[@href='/payment']");
        By card = By.XPath("//input[@data-qa='name-on-card']");
        By cardno = By.XPath("//input[@data-qa='card-number']");
        By cvc = By.XPath("//input[@data-qa='cvc']");
        By exp = By.XPath("//input[@data-qa='expiry-month']");
        By yeara = By.XPath("//input[@data-qa='expiry-year']");
        By cbtn = By.XPath("//button[@data-qa='pay-button']");
        By invoice = By.XPath("//a[text()='Download Invoice']");
        By conti = By.XPath("//a[text()='Continue']");
        By home = By.XPath("//i[@class='fa fa-home']");





        public void addcart(String str_name, String str_mail, String str_pass, String str_dropvalue, String str_dropvaluemo, String str_years, String firstname, String lastname, String companyname, String adress, String county, String str_state, String citty, String zipcode, String phno, String cmnt, String carda, String cardnum, String cvc1, string exp1, String yera)
        {
            AssertionVerify(home);
            Click(addpro);
            Click(addcartt);
            Thread.Sleep(5000);
            Click(viewcart);
            Click(procedcheck);
            Thread.Sleep(5000);
            Click(loginbt);
            Write(name, str_name);
            Write(email, str_mail);
            Click(signupbtn);
            Click(title);
            Write(pass, str_pass);
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
            Click(createbtn);
            Click(contin);
            Click(cartbtn);
            Click(peoced);
            Write(textarea, cmnt);
            Click(placed);
            Write(card, carda);
            Write(cardno, cardnum);
            Write(cvc, cvc1);
            Write(exp, exp1);
            Write(yeara, yera);
            Click(cbtn);
            Click(invoice);
            Click(conti);
        }

    }
}
