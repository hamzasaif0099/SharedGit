using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationWeek2.Practice
{
    public class GmailMethods
    {


        IWebDriver driver = null;


        public GmailMethods(IWebDriver driver) { 
                
            this.driver = driver;        
        
        }


        public void gmailTest(String email, String pass, String userEmail, String subject, String emailBody) {


            driver.FindElement(By.XPath("//input[@id='identifierId']")).SendKeys(email);  
          

            driver.FindElement(By.XPath("//button[@jsname='LgbsSe']")).Click();
            driver.FindElement(By.XPath("//input[@aria-label='Enter your password']")).SendKeys(pass);
            driver.FindElement(By.CssSelector("#passwordNext > div > button")).Click();

            driver.FindElement(By.XPath("//div[@class='T-I T-I-KE L3']")).Click();

            driver.FindElement(By.ClassName("vO")).SendKeys(userEmail);
            driver.FindElement(By.ClassName("aoT")).SendKeys(subject);
            driver.FindElement(By.ClassName("Am")).SendKeys(emailBody);
           
            driver.FindElement(By.ClassName("dC")).Click();
            Thread.Sleep(1000);

        }


        /*
        public void testMethod() {

              Actions a = new Actions(driver);
            //  a.MoveToElement(driver.FindElement(By.XPath("/html/body/header/div[5]/div/div[1]/div/a/span[2]"))).DoubleClick();


            //           driver.FindElement(By.XPath("/html/body/header/div[5]/div/div[1]/div/a/span[2]")).Click();

            a.MoveToElement(driver.FindElement(By.Id("btnSearch"))).DoubleClick().Perform();



        }


        */
    }
}
