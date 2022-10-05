using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace Quiz2Selenium
{
    [TestClass]
    public class UnitTest1 : BasePage

    {
        [TestMethod]
        public void RegisterWithValid()
        {
            Browser("Chrome");
            OpenUrl("https://automationexercise.com/");
            maxwindow();

            Register reg = new Register();
            reg.register("munircon110otur", "munir14123102@gmail.com", "1234", "10", "5", "2021", "Munir", "Hussain", "Contour", "7th, Nishter, ", "Singapore", "Uttar Pardash", "Lahore", "54000", "03025757701");


        }
        [TestMethod]
        public void LoginValid()
        {
            Browser("Chrome");
            OpenUrl("https://automationexercise.com/");
            maxwindow();

            LoginWithValid loginpage = new LoginWithValid();
            loginpage.ValidLogin("munir@gmail.com", "1234");
           

        }

        [TestMethod]
        public void LogoutTC()
        {
            Browser("Chrome");
            OpenUrl("https://automationexercise.com/");
            maxwindow();

            Logout logoutobj = new Logout();
            logoutobj.logout("munir@gmail.com", "1234");


        }
        [TestMethod]
        public void SearchTC()
        {
            Browser("Chrome");
            OpenUrl("https://automationexercise.com/");
            maxwindow();

            SearchProduct searchobj = new SearchProduct();
            searchobj.Searchpage("Men Tshirt");


        }
        [TestMethod]
        public void AddtoCartDownloadTC()
        {
            Browser("Chrome");
            OpenUrl("https://automationexercise.com/");
            maxwindow();

            Downloadinvice addto = new Downloadinvice();
            addto.addcart("munirhussaincontour", "munirhussain1452contour@gmail.com", "1234", "10", "5", "2021", "Munir", "Hussain", "Contour", "7th, Nishter, ", "Singapore", "Uttar Pardash", "Lahore", "54000", "03025757701", "good","VISA","02222", "120","06","2022");


        }

        [TestMethod]
        public void VerifyProTC()
        {
            Browser("Chrome");
            OpenUrl("https://automationexercise.com/");
            maxwindow();

            VerifyProduct verify = new VerifyProduct();
            verify.verifypro();


        }
        [TestMethod]
        public void hoverelemntTC()
        {
            Browser("Chrome");
            OpenUrl("https://automationexercise.com/");
            maxwindow();

            Addtocarthover hoveradd = new Addtocarthover();
            hoveradd.Hoveraddtocart();


        }

        [TestMethod]
        public void PlaceOrder()
        {
            Browser("Chrome");
            OpenUrl("https://automationexercise.com/");
            maxwindow();

            Placeorder placeor = new Placeorder();
            placeor.placeordr("munirhussainfaqeer", "munirhconyour124@gmail.com", "1234", "10", "5", "2021", "Munir", "Hussain", "Contour", "7th, Nishter, ", "Singapore", "Uttar Pardash", "Lahore", "54000", "03025757701", "good", "VISA", "02222", "120", "06", "2022");


        }
    }
}
