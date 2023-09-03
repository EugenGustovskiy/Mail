using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailNew
{
    internal class LoginPage : BasePage
    {
        IWebElement _fieldLogin;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            InitializeLogin();
        }

        private void InitializeLogin()
        {
            _fieldLogin = FindMailElement(Constants.FIELD_LOGIN_XPATH);
        }

        public void EnterLogin(string login)
        {
            Thread.Sleep(2000);
            _fieldLogin.SendKeys(login);
            var buttonFurther = FindMailElement(Constants.FURTHER_XPATH);
            ClickElement(buttonFurther);
        }

        public MainPage EnterPassword(string password)
        {
            Thread.Sleep(5000);
            var fieldPassword = FindMailElement(Constants.FIELD_PASSWORD_XPATH);
            fieldPassword.SendKeys(password);
            var buttonFurther = FindMailElement(Constants.FURTHER_XPATH);
            ClickElement(buttonFurther);
            return new MainPage(_driver);
        }
    }
}
