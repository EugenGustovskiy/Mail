using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace MailNew
{
    internal class BasePage
    {
        protected IWebDriver _driver;
        Actions _action;
        WebDriverWait _wait;

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            _action = new Actions(_driver);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        protected void GoToUrl(string url)
        {
            _driver.Url = url;
            _driver.Manage().Window.Maximize();
        }

        protected void ClickElement(IWebElement webElement)
        {
            _action.MoveToElement(webElement);
            _action.Perform();
            webElement.Click();
        }

        protected IWebElement FindMailElement(string xPath)
        {
            return _wait.Until(ExpectedConditions.ElementExists(By.XPath(xPath)));
        }

        public void CloseProgram()
        {
            _driver.Close();
        }
    }
}