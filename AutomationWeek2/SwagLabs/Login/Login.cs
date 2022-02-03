﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AutomationWeek2.SwagLabs.Login
{
    public class Login
    {
        IWebDriver driver = null;

        public Login(IWebDriver driver)
        {

            this.driver = driver;
        }


        By usernameEnter = By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[1]/input");
        By passwordEnter = By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[2]/input");

        By loginButtonLocator = By.Id("login-button");



        //Login
        public void loginSauceLab(String username, String password)
        {

            driver.FindElement(usernameEnter).SendKeys(username); //insert username
            driver.FindElement(passwordEnter).SendKeys(password); //insert password

            driver.FindElement(loginButtonLocator).Click(); //insert password

        }




    }
}
